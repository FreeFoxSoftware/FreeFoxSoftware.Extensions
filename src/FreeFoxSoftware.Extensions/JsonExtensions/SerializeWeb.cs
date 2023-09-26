using System.Text.Json;

namespace FreeFoxSoftware.Extensions.JsonExtensions;

public static partial class JsonExtensions
{
    /// <summary>
    /// Serializes an Object using web default with relaxed json escaping and enum conversion
    /// </summary>
    /// <param name="obj">Object to be serialized</param>
    /// <typeparam name="T">Type to serialize </typeparam>
    /// <returns>Serialized object as a string</returns>
    public static string SerializeWeb<T>(this T obj)
    {
        return JsonSerializer.Serialize(obj, JsonSerializationConstants.Options);
    }
}