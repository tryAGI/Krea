# CLAUDE.md -- Krea SDK

## Overview

Auto-generated C# SDK for [Krea AI](https://krea.ai) — a unified API covering 40+
state-of-the-art generative models for **image**, **video**, and **image-enhancement**
through a single account. As of 2026-04, Krea exposes **no public OpenAPI spec**;
`src/libs/Krea/openapi.yaml` was handcrafted from the public documentation site
(`https://docs.krea.ai` and `https://docs.krea.ai/llms-full.txt`).

Krea's platform is young (launched late 2025) and evolves quickly — expect new model
endpoints to land regularly. When that happens, consult `llms-full.txt` for the canonical
endpoint list and add new paths to `openapi.yaml` using the existing shared request
schemas (see "Spec strategy" below).

## Build & Test

```bash
dotnet build Krea.slnx
dotnet test src/tests/IntegrationTests/      # requires KREA_API_KEY; otherwise inconclusive
```

## Auth

Bearer token auth:

```csharp
using var client = new KreaClient(apiKey); // KREA_API_KEY env var
```

Base URL: `https://api.krea.ai`

## Async job pattern

Every `/generate/*` endpoint is **asynchronous**. The POST returns a `Job`
(`job_id`, `status == backlogged | queued | ... | completed | failed | cancelled`,
`created_at`, `completed_at`, `result`). Poll for completion:

```csharp
var job = await client.Image.GenerateFlux11ProAsync(new ImageGenerationRequest
{
    Prompt = "A futuristic skyline at sunset",
    Width = 1024, Height = 1024,
});

while (job.Status != JobStatus.Completed && job.Status != JobStatus.Failed)
{
    await Task.Delay(TimeSpan.FromSeconds(3));
    job = await client.Jobs.GetJobAsync(job.JobId.ToString());
}

foreach (var url in job.Result?.Urls ?? []) Console.WriteLine(url);
```

Most `/generate/image/*` endpoints also accept an optional `X-Webhook-URL` header to
receive a push notification instead of polling.

## Sub-clients

| Sub-client | What it does |
|------------|--------------|
| `client.Image` | 21 image-generation + editing models (Flux, Imagen 3/4, Nano Banana, Ideogram, Seedream, Qwen, Z Image, Runway Gen-4, GPT Image, Flux Kontext, SeedEdit) |
| `client.Video` | 31 video-generation models (Veo 2/3/3.1, Sora 2, Kling 1-2.6, Hailuo, Ray 2, Runway Gen-3/4/4.5, Seedance, Wan 2.1/2.2/2.5) |
| `client.Enhance` | Topaz upscale/enhance (Standard, Bloom, Generative) |
| `client.Jobs` | List / get / delete jobs (status polling) |
| `client.Assets` | Upload / list / get / delete user assets (JPEG/PNG/WebP/HEIC/MP4/MOV/WebM/GLB/WAV/MP3, 75 MB max) |
| `client.Styles` | Train custom LoRA styles (`/styles/train`), list, get, patch, share |
| `client.NodeApps` | Retrieve and execute Krea "Node App" visual workflows |

## Spec strategy

When adding a new Krea model:

1. Look up the model's endpoint + request body in `https://docs.krea.ai/api-reference/<category>/<model>.md`.
2. Add a new path under `paths:` in `openapi.yaml`.
3. Re-use one of the shared request schemas:
   - `ImageGenerationRequest` — default text-to-image (prompt + width/height/batchSize/seed/styleImages/styles)
   - `FluxKontextRequest` — image-editing (primary `imageUrl` + style refs)
   - `NanoBananaProRequest`, `IdeogramRequest` — model-specific image bodies
   - `VideoGenerationRequest` — default video body
   - `KlingVideoRequest`, `Veo3Request`, `Sora2Request` — model-specific video bodies
   - `TopazEnhanceRequest` — Topaz enhancement
4. Every operation returns `$ref: '#/components/schemas/Job'`.
5. Re-run `./generate.sh`.

Coverage as of 2026-04:
- 21 image models + 3 image editing (Flux Kontext, SeedEdit via FluxKontextRequest, Nano Banana Pro)
- 31 video models
- 3 Topaz enhancement endpoints
- Full CRUD for `/jobs`, `/assets`
- Full `/styles` surface including LoRA training + sharing
- `/node-apps` execution

**Not yet covered** (watch `llms-full.txt`):
- 3D generation endpoints — they are mentioned in user-facing docs but have no
  published API reference page at `docs.krea.ai/api-reference/*` yet. When they
  ship (likely `/generate/3d/<provider>/<model>`), add them under a new `ThreeD` tag.
- Realtime canvas endpoints — also not yet in the public API reference.
- Audio generation — not yet exposed.

## MEAI Integration

`src/libs/Krea/Extensions/KreaClient.Tools.cs` exposes 5 `AIFunction` tools for use
with any `IChatClient`:

| Tool | Description |
|------|-------------|
| `AsGenerateImageTool(model = "flux-1.1-pro")` | Text-to-image across any supported image model |
| `AsEditImageTool()` | Image editing via Flux Kontext |
| `AsGenerateVideoTool(model = "veo-3")` | Text-to-video across any supported video model |
| `AsEnhanceImageTool()` | Upscale/enhance via Topaz Standard |
| `AsGetJobTool()` | Poll any job by `job_id` |

No MEAI interface (`IChatClient` / `IEmbeddingGenerator` / `ISpeechToTextClient`) is
implemented — Krea is a generation platform with no direct conversational/embedding/STT
counterpart.

## Key files

- `src/libs/Krea/openapi.yaml` — **manually maintained** spec (keep in sync with docs.krea.ai)
- `src/libs/Krea/generate.sh` — calls autosdk with `--security-scheme Http:Header:Bearer`
- `src/libs/Krea/Generated/` — **never edit** (auto-generated)
- `src/libs/Krea/Extensions/KreaClient.Tools.cs` — MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` — shared `GetAuthenticatedClient` helper
- `src/tests/IntegrationTests/Examples/` — example tests (also serve as docs)
