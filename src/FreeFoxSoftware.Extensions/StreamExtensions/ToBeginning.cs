namespace FreeFoxSoftware.Extensions.StreamExtensions;

public static partial class StreamExtensions
{
    /// <summary>
    /// Sets the stream position to the beginning of the stream
    /// </summary>
    /// <param name="source"></param>
    public static void ToBeginning(this Stream source)
    {
        source.Seek(0, SeekOrigin.Begin);
    }
}