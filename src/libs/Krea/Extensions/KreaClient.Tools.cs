#pragma warning disable CS3002 // Return type is not CLS-compliant
using System.Text;
using Microsoft.Extensions.AI;

namespace Krea;

/// <summary>
/// Extensions that turn <see cref="KreaClient"/> into a collection of MEAI <see cref="AIFunction"/>
/// tools that can be handed to any <see cref="IChatClient"/>.
/// </summary>
[System.CLSCompliant(false)]
public static class KreaToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates an image from a text prompt
    /// using any Krea image model (default Flux 1.1 Pro). Submits an asynchronous job —
    /// use <see cref="AsGetJobTool"/> to poll for completion.
    /// </summary>
    /// <param name="client">The Krea client to use.</param>
    /// <param name="model">
    /// Krea image-model slug. Common values: "flux-1.1-pro", "flux-1.1-pro-ultra", "imagen-4",
    /// "imagen-4-ultra", "nano-banana-pro", "ideogram-3", "seedream-4", "gpt-image".
    /// </param>
    public static AIFunction AsGenerateImageTool(
        this KreaClient client,
        string model = "flux-1.1-pro")
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string prompt, double? width, double? height, CancellationToken cancellationToken) =>
            {
                var request = new ImageGenerationRequest
                {
                    Prompt = prompt,
                    Width = width,
                    Height = height,
                };

                var job = model switch
                {
                    "flux-1-dev" or "flux" => await client.Image.GenerateFluxAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false),
                    "flux-1.1-pro-ultra" => await client.Image.GenerateFlux11ProUltraAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false),
                    "imagen-3" => await client.Image.GenerateImagen3Async(request, cancellationToken: cancellationToken).ConfigureAwait(false),
                    "imagen-4" => await client.Image.GenerateImagen4Async(request, cancellationToken: cancellationToken).ConfigureAwait(false),
                    "imagen-4-fast" => await client.Image.GenerateImagen4FastAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false),
                    "imagen-4-ultra" => await client.Image.GenerateImagen4UltraAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false),
                    "nano-banana" => await client.Image.GenerateNanoBananaAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false),
                    "nano-banana-2" => await client.Image.GenerateNanoBanana2Async(request, cancellationToken: cancellationToken).ConfigureAwait(false),
                    "nano-banana-pro" => await client.Image.GenerateNanoBananaProAsync(
                        new NanoBananaProRequest { Prompt = prompt, Width = width, Height = height },
                        cancellationToken: cancellationToken).ConfigureAwait(false),
                    "ideogram-2-turbo" => await client.Image.GenerateIdeogram2TurboAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false),
                    "ideogram-3" => await client.Image.GenerateIdeogram3Async(
                        new IdeogramRequest { Prompt = prompt, Width = width, Height = height },
                        cancellationToken: cancellationToken).ConfigureAwait(false),
                    "qwen-2512" => await client.Image.GenerateQwen2512Async(request, cancellationToken: cancellationToken).ConfigureAwait(false),
                    "runway-gen-4" => await client.Image.GenerateRunwayGen4ImageAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false),
                    "seedream-3" => await client.Image.GenerateSeedream3Async(request, cancellationToken: cancellationToken).ConfigureAwait(false),
                    "seedream-4" => await client.Image.GenerateSeedream4Async(request, cancellationToken: cancellationToken).ConfigureAwait(false),
                    "seedream-5-lite" => await client.Image.GenerateSeedream5LiteAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false),
                    "z-image" => await client.Image.GenerateZImageAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false),
                    "gpt-image" or "chatgpt-image" => await client.Image.GenerateChatGptImageAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false),
                    _ => await client.Image.GenerateFlux11ProAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false),
                };

                return FormatJob(job, $"image generation ({model})");
            },
            name: "GenerateImage",
            description: "Starts an asynchronous Krea image-generation job from a text prompt. Returns a job_id and status; use GetJob to retrieve the completed output URLs.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that edits an image via Flux Kontext, given a source URL and a text instruction.
    /// </summary>
    public static AIFunction AsEditImageTool(this KreaClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string prompt, string imageUrl, CancellationToken cancellationToken) =>
            {
                var request = new FluxKontextRequest
                {
                    Prompt = prompt,
                    ImageUrl = imageUrl,
                };
                var job = await client.Image.GenerateFluxKontextAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false);
                return FormatJob(job, "image edit (flux-kontext)");
            },
            name: "EditImage",
            description: "Edits an existing image using Krea's Flux Kontext model. Takes the source `imageUrl` plus a natural-language edit instruction and returns an asynchronous job_id.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates a video from a text prompt
    /// (optionally seeded by a start-image URL) using any Krea video model.
    /// </summary>
    /// <param name="client">The Krea client to use.</param>
    /// <param name="model">
    /// Krea video-model slug. Common values: "veo-3", "veo-3.1", "sora-2", "kling-2.1", "kling-2.6",
    /// "hailuo-2.3", "runway-gen-4", "seedance-2", "ray-2", "wan-2.5".
    /// </param>
    public static AIFunction AsGenerateVideoTool(
        this KreaClient client,
        string model = "veo-3")
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string prompt, string? startImage, double? duration, CancellationToken cancellationToken) =>
            {
                Job job = model switch
                {
                    "sora-2" => await client.Video.GenerateSora2Async(
                        new Sora2Request { Prompt = prompt, StartImage = startImage, Duration = duration },
                        cancellationToken: cancellationToken).ConfigureAwait(false),
                    "veo-2" => await client.Video.GenerateVeo2Async(
                        new VideoGenerationRequest { Prompt = prompt, StartImage = startImage, Duration = duration },
                        cancellationToken: cancellationToken).ConfigureAwait(false),
                    "veo-3-fast" => await client.Video.GenerateVeo3FastAsync(
                        new Veo3Request { Prompt = prompt, StartImage = startImage, Duration = duration },
                        cancellationToken: cancellationToken).ConfigureAwait(false),
                    "veo-3.1" => await client.Video.GenerateVeo31Async(
                        new Veo3Request { Prompt = prompt, StartImage = startImage, Duration = duration },
                        cancellationToken: cancellationToken).ConfigureAwait(false),
                    "veo-3.1-fast" => await client.Video.GenerateVeo31FastAsync(
                        new Veo3Request { Prompt = prompt, StartImage = startImage, Duration = duration },
                        cancellationToken: cancellationToken).ConfigureAwait(false),
                    "veo-3.1-lite" => await client.Video.GenerateVeo31LiteAsync(
                        new Veo3Request { Prompt = prompt, StartImage = startImage, Duration = duration },
                        cancellationToken: cancellationToken).ConfigureAwait(false),
                    "kling-2.1" => await client.Video.GenerateKling21Async(
                        new KlingVideoRequest { Prompt = prompt, StartImage = startImage },
                        cancellationToken: cancellationToken).ConfigureAwait(false),
                    "kling-2.5" => await client.Video.GenerateKling25Async(
                        new KlingVideoRequest { Prompt = prompt, StartImage = startImage },
                        cancellationToken: cancellationToken).ConfigureAwait(false),
                    "kling-2.6" => await client.Video.GenerateKling26Async(
                        new KlingVideoRequest { Prompt = prompt, StartImage = startImage },
                        cancellationToken: cancellationToken).ConfigureAwait(false),
                    "hailuo-2.3" => await client.Video.GenerateHailuo23Async(
                        new VideoGenerationRequest { Prompt = prompt, StartImage = startImage, Duration = duration },
                        cancellationToken: cancellationToken).ConfigureAwait(false),
                    "runway-gen-4" => await client.Video.GenerateRunwayGen4VideoAsync(
                        new VideoGenerationRequest { Prompt = prompt, StartImage = startImage, Duration = duration },
                        cancellationToken: cancellationToken).ConfigureAwait(false),
                    "seedance-2" => await client.Video.GenerateSeedance2Async(
                        new VideoGenerationRequest { Prompt = prompt, StartImage = startImage, Duration = duration },
                        cancellationToken: cancellationToken).ConfigureAwait(false),
                    "ray-2" => await client.Video.GenerateRay2Async(
                        new VideoGenerationRequest { Prompt = prompt, StartImage = startImage, Duration = duration },
                        cancellationToken: cancellationToken).ConfigureAwait(false),
                    "wan-2.5" => await client.Video.GenerateWan25Async(
                        new VideoGenerationRequest { Prompt = prompt, StartImage = startImage, Duration = duration },
                        cancellationToken: cancellationToken).ConfigureAwait(false),
                    _ => await client.Video.GenerateVeo3Async(
                        new Veo3Request { Prompt = prompt, StartImage = startImage, Duration = duration },
                        cancellationToken: cancellationToken).ConfigureAwait(false),
                };

                return FormatJob(job, $"video generation ({model})");
            },
            name: "GenerateVideo",
            description: "Starts an asynchronous Krea video-generation job from a text prompt. Returns a job_id and status; use GetJob to retrieve the completed video URL.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that upscales / enhances an image using Topaz Standard.
    /// </summary>
    public static AIFunction AsEnhanceImageTool(this KreaClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string imageUrl, double width, double height, double? scalingFactor, CancellationToken cancellationToken) =>
            {
                var request = new TopazEnhanceRequest
                {
                    ImageUrl = imageUrl,
                    Width = width,
                    Height = height,
                    Model = TopazEnhanceRequestModel.StandardV2,
                    UpscalingActivated = scalingFactor.HasValue,
                    ImageScalingFactor = scalingFactor,
                };
                var job = await client.Enhance.EnhanceTopazStandardAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false);
                return FormatJob(job, "image enhancement (topaz)");
            },
            name: "EnhanceImage",
            description: "Upscales or enhances an image using Krea's Topaz Standard enhancement. Accepts a source image URL plus target width/height and returns an asynchronous job_id.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that polls a Krea job by ID.
    /// </summary>
    public static AIFunction AsGetJobTool(this KreaClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string jobId, CancellationToken cancellationToken) =>
            {
                var job = await client.Jobs.GetJobAsync(jobId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return FormatJob(job, "job status");
            },
            name: "GetJob",
            description: "Retrieves the status and, when completed, the output URLs of a Krea generation job by its `job_id`.");
    }

    private static string FormatJob(Job job, string taskType)
    {
        var builder = new StringBuilder();
        builder.Append("Job ID: ").AppendLine(job.JobId.ToString());
        builder.Append("Status: ").AppendLine(job.Status.ToValueString());
        builder.Append("Type: ").AppendLine(taskType);

        if (job.Status == JobStatus.Completed && job.Result?.Urls is { Count: > 0 } urls)
        {
            builder.AppendLine("Outputs:");
            foreach (var url in urls)
            {
                builder.Append("- ").AppendLine(url);
            }
        }
        else if (job.Status == JobStatus.Failed || job.Status == JobStatus.Cancelled)
        {
            builder.AppendLine("The job did not complete successfully. Query GetJob again or start a new job.");
        }
        else
        {
            builder.AppendLine("Job is in progress. Call GetJob with this job_id to poll until status == completed.");
        }

        return builder.ToString();
    }
}
