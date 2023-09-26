namespace FreeFoxSoftware.Extensions.ObjectExtensions;

public static partial class ObjectExtensions
{
    /// <summary>
    ///     Checks if an object is null
    /// </summary>
    /// <param name="obj">the object to act on</param>
    /// <returns>True if object is null otherwise false</returns>
    public static bool IsNull(this object? obj)
    {
        return obj == null;
    }
}