/*
order: 40
title: MEAI AIFunction tools
slug: meai-tools

Shows how to turn the Krea client into a bundle of Microsoft.Extensions.AI
`AIFunction` tools that can be handed to any `IChatClient`.
*/

namespace Krea.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsGenerateImageTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create an image-generation tool defaulting to Flux 1.1 Pro.
        var tool = client.AsGenerateImageTool();
        tool.Name.Should().Be("GenerateImage");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsEditImageTool()
    {
        using var client = GetAuthenticatedClient();

        //// Image-editing tool using Flux Kontext.
        var tool = client.AsEditImageTool();
        tool.Name.Should().Be("EditImage");
    }

    [TestMethod]
    public void AsGenerateVideoTool()
    {
        using var client = GetAuthenticatedClient();

        //// Video-generation tool with Veo 3 as the default model.
        var tool = client.AsGenerateVideoTool();
        tool.Name.Should().Be("GenerateVideo");
    }

    [TestMethod]
    public void AsEnhanceImageTool()
    {
        using var client = GetAuthenticatedClient();

        //// Topaz-powered upscale/enhance tool.
        var tool = client.AsEnhanceImageTool();
        tool.Name.Should().Be("EnhanceImage");
    }

    [TestMethod]
    public void AsGetJobTool()
    {
        using var client = GetAuthenticatedClient();

        //// Status-polling tool. Call with a job_id returned from any of the generator tools.
        var tool = client.AsGetJobTool();
        tool.Name.Should().Be("GetJob");
    }

    [TestMethod]
    public void CombineAllTools()
    {
        using var client = GetAuthenticatedClient();

        //// Combine all Krea tools into a single array suitable for ChatOptions.Tools.
        var tools = new[]
        {
            client.AsGenerateImageTool(),
            client.AsEditImageTool(),
            client.AsGenerateVideoTool(),
            client.AsEnhanceImageTool(),
            client.AsGetJobTool(),
        };

        tools.Should().HaveCount(5);
        tools.Select(t => t.Name).Should().OnlyHaveUniqueItems();
    }
}
