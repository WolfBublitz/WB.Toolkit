using AwesomeAssertions;
using WB.Processing;

namespace ProcessTests.PropertyTests.CommandPropertyTests;

public sealed class TheCommandProperty
{
    [Test]
    public void ShouldProvideTheCommandOfTheProcess()
    {
        // Arrange
        using Process process = new("test");

        // Act
        string command = process.Command;

        // Assert
        command.Should().Be("test");
    }
}