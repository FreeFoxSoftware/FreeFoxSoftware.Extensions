using FluentAssertions;
using FreeFoxSoftware.Extensions.JsonExtensions;

namespace UnitTests.JsonExtensions;

public class DeserializeWebTests
{
    private enum FormatEnum
    {
        Xml,
        Json
    }

    private class Data
    {
        public FormatEnum FormatEnum { get; set; }
    }

    [Fact]
    public void WhenObjectHasEnum_ShouldDeserializeAndMapEnumType()
    {
        var jsonString = @"{ ""FormatEnum"": ""Json""}";
        var data = jsonString.DeserializeWeb<Data>();
        data!.FormatEnum.Should().Be(FormatEnum.Json);
    }
}