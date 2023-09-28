using FluentAssertions;
using FreeFoxSoftware.Extensions.CollectionExtensions;

namespace UnitTests.CollectionTests;

public class AddIfTests
{
    [Fact]
    public void GivenCollectionIsEmpty_WhenPredicateReturnsFalse_CollectionShouldHaveNoElements()
    {
        var elements = new List<string>();
        elements.AddIf("element", () => 0 == 1);
        elements.Should().BeEmpty();
    }
    
    [Fact]
    public void GivenCollectionIsEmpty_WhenPredicateReturnsTrue_CollectionShouldContainSingleElement()
    {
        var elements = new List<string>();
        elements.AddIf("element", () => true);
        elements.Should().ContainSingle();
        elements.First().Should().Be("element");
    }
}