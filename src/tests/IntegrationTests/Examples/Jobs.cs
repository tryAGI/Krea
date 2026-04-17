/*
order: 30
title: List jobs
slug: list-jobs

List jobs for the authenticated account. Works as a smoke-test for auth.
*/

namespace Krea.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListJobs()
    {
        using var client = GetAuthenticatedClient();

        //// List the most recent jobs.
        var list = await client.Jobs.ListJobsAsync(limit: 5);
        list.Should().NotBeNull();
        Console.WriteLine($"jobs returned: {list.Items?.Count ?? 0}");
    }
}
