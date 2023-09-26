using System.Text;

namespace FreeFoxSoftware.Extensions.StringExtensions;

/// <summary>
/// A set of String extensions
/// </summary>
public static partial class StringExtensions
{
    /// <summary>
    /// Converts string to a MemoryStream
    /// </summary>
    /// <param name="source"></param>
    /// <returns>MemoryStream</returns>
    public static MemoryStream ToMemoryStream(this string source)
    {
        var byteArray = Encoding.UTF8.GetBytes(source);
        return new MemoryStream(byteArray);
    }
}