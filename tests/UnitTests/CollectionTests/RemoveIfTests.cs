using FluentAssertions;
using FreeFoxSoftware.Extensions.CollectionExtensions;

namespace UnitTests.CollectionTests;

public class RemoveIfTests
{
    [Fact]
    public void GivenCollectionHasSingleElement_WhenPredicateReturnsFalse_CollectionShouldHaveSingleElement()
    {
        var elements = new List<string> { "element" };
        elements.RemoveIf("element", () => false);
        elements.Should().ContainSingle();
    }
    
    [Fact]
    public void GivenCollectionHasSingleElement_WhenPredicateReturnsTrue_CollectionShouldBeEmpty()
    {
        var elements = new List<string> { "element" };
        elements.RemoveIf("element", () => true);
        elements.Should().BeEmpty();
    }
}