using System.Text;
using AutoFixture;
using FluentAssertions;
using FreeFoxSoftware.Extensions.StreamExtensions;

namespace UnitTests.MemoryStreamTests;

public class ToBeginningTests : UnitTestBase
{
    public ToBeginningTests()
    {
        EnableMemoryStreamFixture(true);
    }
    
    [Fact]
    public void ShouldSetToBeginningOfStream()
    {
        var stream = Fixture.Create<MemoryStream>();
        stream.Position.Should().NotBe(0);
        stream.ToBeginning();
        stream.Position.Should().Be(0);
    }
}