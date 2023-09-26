using System.Text;
using AutoFixture;
using FluentAssertions;
using FreeFoxSoftware.Extensions.StreamExtensions;

namespace UnitTests.MemoryStreamTests;

public class ToUtf8StringTests : UnitTestBase
{
    private readonly string _testString;
    public ToUtf8StringTests()
    {
        _testString = Fixture.Create<string>();
        EnableMemoryStreamFixture(_testString);
    }   
    [Fact]
    public void WhenMemoryStreamContainsString_ShouldReturnString()
    {
        var ms = Fixture.Create<MemoryStream>();
        var result = ms.ToUtf8String();
        result.Should().Be(_testString);
    }
}