using FluentAssertions;
using FreeFoxSoftware.Extensions.ObjectExtensions;

namespace UnitTests.ObjectTests;

public class IsNullTests
{
    [Fact]
    public void WhenObjectIsNull_ShouldReturnTrue()
    {
        object? val = null;
        var result = val.IsNull();
        result.Should().BeTrue();
    }
        
    [Fact]
    public void WhenObjectIsNotNull_ShouldReturnFalse()
    {
        object? val = new object();
        var result = val.IsNull();
        result.Should().BeFalse();
    }
}