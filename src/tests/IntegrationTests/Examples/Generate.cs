/*
order: 10
title: Generate an image
slug: generate

Generate an image with Flux 1.1 Pro. The endpoint is asynchronous:
the response contains a `job_id` plus a starting status. Poll
`client.Jobs.GetJobAsync(jobId)` until `status == completed`
to retrieve the final URL.
*/

namespace Krea.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Generate()
    {
        using var client = GetAuthenticatedClient();

        //// Kick off a Flux 1.1 Pro image-generation job.
        var job = await client.Image.GenerateFlux11ProAsync(new ImageGenerationRequest
        {
            Prompt = "A futuristic city skyline at sunset, cinematic lighting",
            Width = 1024,
            Height = 1024,
        });

        job.JobId.Should().NotBe(Guid.Empty);
        Console.WriteLine($"job_id={job.JobId} status={job.Status.ToValueString()}");
    }
}
