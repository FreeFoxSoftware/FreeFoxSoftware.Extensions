using AutoFixture;
using FluentAssertions;
using FreeFoxSoftware.Extensions.StreamExtensions;
using FreeFoxSoftware.Extensions.StringExtensions;

namespace UnitTests.StringTests;

public class ToMemoryStreamTests
{
    private readonly Fixture _fixture = new();
    
    [Fact]
    public void ShouldConvertToMemoryStream()
    {
        var stream = "".ToMemoryStream();
        stream.Should().NotBeNull();
    }
    
    [Fact]
    public void ConvertedMemoryStreamShouldHaveCorrectData()
    {
        var data = _fixture.Create<string>();
        var result = data.ToMemoryStream().ToUtf8String();
        result.Should().Be(data);
    }
}