using System.Collections.Generic;
using System.Linq;

namespace FreeFoxSoftware.Extensions.DictionaryExtensions;

public static partial class DictionaryExtensions
{
    /// <summary>
    ///     An IDictionary that copies one IDictionary to another
    /// </summary>
    /// <param name="dict">The dictionary to act on.</param>
    /// <returns>An IDictionary.</returns>
    public static IDictionary<TKey, TValue> Copy<TKey, TValue>(this IDictionary<TKey, TValue> dict)
    {
        return dict.ToDictionary(k => k.Key, v => v.Value);
    }
}