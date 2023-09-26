using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FreeFoxSoftware.Extensions.JsonExtensions;

internal class JsonSerializationConstants
{
    /// <see cref="JsonSerializationConstants"/>
    public static readonly JsonSerializerOptions Options = new(JsonSerializerDefaults.Web)
    {
        
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        Converters = { new JsonStringEnumConverter() }
    };
}