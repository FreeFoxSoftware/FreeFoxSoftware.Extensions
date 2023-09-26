using FluentAssertions;
using FreeFoxSoftware.Extensions.ObjectExtensions;

namespace UnitTests.ObjectTests;

public class IsDefaultTests
{
    [Fact]
    public void GivenProvidingInteger_WhenValueIs0_ShouldBeTrue()
    {
        var result = 0.IsDefault();
        result.Should().BeTrue();
    }
        
    [Fact]
    public void GivenProvidingInteger_WhenValueIs1_ShouldBeFalse()
    {
        var result = 1.IsDefault();
        result.Should().BeFalse();
    }

    [Fact]
    public void GivenProvidingNullableInt_WhenValueIsNull_ShouldReturnTrue()
    {
        int? val = null;
        var result = val.IsDefault();
        result.Should().Be(true);
    }
}