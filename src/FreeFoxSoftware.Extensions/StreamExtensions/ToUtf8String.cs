using System.Text;

namespace FreeFoxSoftware.Extensions.StreamExtensions;

/// <summary>
/// A set of Stream extensions
/// </summary>
public static partial class StreamExtensions
{
    /// <summary>
    /// Returns string value from provided MemoryStream
    /// </summary>
    /// <param name="source"></param>
    /// <returns>The string that was stored in the provided MemoryStream</returns>
    public static string ToUtf8String(this MemoryStream source)
    {
        return Encoding.UTF8.GetString(source.ToArray());
    }
}