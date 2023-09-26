using System.Text.Json;

namespace FreeFoxSoftware.Extensions.JsonExtensions;

/// <summary>
/// Extensions to help with JSON
/// </summary>
public static partial class JsonExtensions
{
    /// <summary>
    /// Deserializes a string using web default with relaxed json escaping and enum conversion
    /// </summary>
    /// <param name="str">string to be deserialized</param>
    /// <typeparam name="T">Type to deserialize into</typeparam>
    /// <returns>Instance of type T</returns>
    public static T? DeserializeWeb<T>(this string str)
    {
        return JsonSerializer.Deserialize<T>(str, JsonSerializationConstants.Options);
    }
}