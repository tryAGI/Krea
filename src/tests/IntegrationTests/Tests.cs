namespace Krea.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static KreaClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("KREA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("KREA_API_KEY environment variable is not found.");

        var client = new KreaClient(apiKey);
        
        return client;
    }
}
