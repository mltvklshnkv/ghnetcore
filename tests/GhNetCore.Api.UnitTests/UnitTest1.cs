using FluentAssertions;

namespace GhNetCore.Api.UnitTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        false.Should().BeTrue();
    }
}