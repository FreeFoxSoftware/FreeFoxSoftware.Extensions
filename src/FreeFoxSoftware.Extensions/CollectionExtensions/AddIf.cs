namespace FreeFoxSoftware.Extensions.CollectionExtensions;

public static partial class CollectionExtensions
{
    /// <summary>
    ///     Add to collection if the predicate returns true
    /// </summary>
    /// <param name="collection">The collection to act upon</param>
    /// <param name="element">Element to add if the predicate returns true</param>
    /// <param name="predicate">A Func that should return a boolean</param>
    /// <typeparam name="T"></typeparam>
    public static void AddIf<T>(this ICollection<T> collection, T element, Func<bool> predicate)
    {
        if (predicate())
        {
            collection.Add(element);
        }
    }
}