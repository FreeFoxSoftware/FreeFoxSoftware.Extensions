using AutoFixture;
using FluentAssertions;
using FreeFoxSoftware.Extensions.DictionaryExtensions;

namespace UnitTests.DictionaryTests;

public class CopyTests
{
    private readonly Fixture _fixture = new();
        
    [Fact]
    public void ShouldCopySingleItem()
    {
        var dict = new Dictionary<string, string>();
        var key = _fixture.Create<string>();
        var value = _fixture.Create<string>();
        dict.Add(key, value);

        var copy = dict.Copy();
        copy.Should().HaveCount(1);
        copy.Should().ContainKey(key).WhoseValue.Should().Be(value);
    }
        
    [Fact]
    public void ShouldCopyMultipleItem()
    {
        var dict = _fixture.Create<Dictionary<string, string>>();
        var copy = dict.Copy();
        copy.Should().BeEquivalentTo(dict);
    }
}