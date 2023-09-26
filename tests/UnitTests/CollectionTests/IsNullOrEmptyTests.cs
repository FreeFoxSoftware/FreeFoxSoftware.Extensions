using FluentAssertions;
using FreeFoxSoftware.Extensions.CollectionExtensions;

namespace UnitTests.CollectionTests;

public class IsNullOrEmptyTests
{
    [Fact]
    public void WhenCollectionIsNull_ShouldReturnTrue()
    {
        ICollection<string>? collection = null;
        var result = collection.IsNullOrEmpty();
        result.Should().BeTrue();
    }
        
    [Fact]
    public void WhenCollectionIsEmpty_ShouldReturnTrue()
    {
        var collection = new List<string>();
        var result = collection.IsNullOrEmpty();
        result.Should().BeTrue();
    }
        
        
    [Fact]
    public void WhenCollectionIsNotNullOrEmpty_ShouldReturnFalse()
    {
        var collection = new List<string> {"value"};
        var result = collection.IsNullOrEmpty();
        result.Should().BeFalse();
    }
}