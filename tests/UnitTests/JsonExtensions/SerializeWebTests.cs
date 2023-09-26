using FluentAssertions;
using FreeFoxSoftware.Extensions.JsonExtensions;

namespace UnitTests.JsonExtensions;

public class SerializeWebTests
{
    private enum FormatEnum
    {
        Xml,
        Json
    }

    [Serializable]
    private class Data
    {
        public Data(FormatEnum formatEnum)
        {
            FormatEnum = formatEnum;
        }
        public FormatEnum FormatEnum { get; set; }
    }

    [Fact]
    public void WhenObjectHasEnum_ShouldDeserializeAndMapEnumType()
    {
        var obj = new Data(FormatEnum.Json);
        var data = obj.SerializeWeb();
        data.Should().Contain("Json");
    }
}