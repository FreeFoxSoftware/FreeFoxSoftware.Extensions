namespace FreeFoxSoftware.Extensions.ObjectExtensions;

public static partial class ObjectExtensions
{
    /// <summary>
    ///     Checks if an object is null or a default value
    /// </summary>
    /// <param name="obj">the object to act on</param>
    /// <returns>True if object is the default value of the type otherwise false</returns>
    public static bool IsDefault<T>(this T? obj)
    {
#pragma warning disable CS8602
        return obj.Equals(default(T));
#pragma warning restore CS8602
    }
}