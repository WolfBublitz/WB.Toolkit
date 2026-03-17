using System.Threading.Tasks;
using AwesomeAssertions;
using WB.Toolkit.IO;

namespace ProcessTests.MethodTests.ExecuteAsyncMethodTests;

public sealed class TheExecuteAsyncMethod
{
    [Test]
    [Arguments("--version", 0)]
    [Arguments("--invalid", 1)]
    public async Task ShouldReturnTheExitCode(string argument, int exitCode)
    {
        // Arrange
        using Process process = new("dotnet", [argument]);

        // Act
        int actualExitCode = await process.ExecuteAsync().ConfigureAwait(false);

        // Assert
        actualExitCode.Should().Be(exitCode, because: "the process should exit with the specified code");
    }
}