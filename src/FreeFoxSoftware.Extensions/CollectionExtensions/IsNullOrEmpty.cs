using System.Collections.Generic;
using System.Linq;

namespace FreeFoxSoftware.Extensions.CollectionExtensions;

public static partial class CollectionExtensions
{
        
    /// <summary>
    ///     Checks if an object is null
    /// </summary>
    /// <param name="collection">the collection to act on</param>
    /// <returns>True if object is null or empty otherwise false</returns>
    public static bool IsNullOrEmpty<T>(this ICollection<T>? collection)
    {
        return collection == null || !collection.Any();
    }
}