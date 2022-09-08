using FakeItEasy;

namespace PolyDeploy.DeployClient.Tests;

public static class TestHelpers
{
    public static DeployInput CreateDeployInput(string? targetUri = null, string? apiKey = null, string? encryptionKey = null, int? installationStatusTimeout = null)
    {
        return new DeployInput
        {
            TargetUri = targetUri ?? "https://test.com",
            ApiKey = apiKey ?? A.Dummy<string>(),
            EncryptionKey = encryptionKey ?? A.Dummy<string>(),
            InstallationStatusTimeout = installationStatusTimeout ?? 0
        };
    }
}