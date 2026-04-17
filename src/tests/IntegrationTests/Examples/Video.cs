/*
order: 20
title: Generate a video
slug: video

Generate a short video with Veo 3.
*/

namespace Krea.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GenerateVideo()
    {
        using var client = GetAuthenticatedClient();

        //// Submit a Veo 3 video-generation job and print the job_id.
        var job = await client.Video.GenerateVeo3Async(new Veo3Request
        {
            Prompt = "Drone flight over a forest at dawn, cinematic",
            Duration = 4,
        });

        job.JobId.Should().NotBe(Guid.Empty);
        Console.WriteLine($"job_id={job.JobId} status={job.Status.ToValueString()}");
    }
}
