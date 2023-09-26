using System.Text;
using AutoFixture;

namespace UnitTests;

public class UnitTestBase
{
    protected readonly Fixture Fixture = new();
    private readonly Random _random = new();
    
    protected void EnableMemoryStreamFixture(bool shouldSeekToRandomPosition)
    {
        var data = Fixture.Create<string>();
        EnableMemoryStreamFixture(shouldSeekToRandomPosition, data);
    }
    protected void EnableMemoryStreamFixture(string data)
    {
        EnableMemoryStreamFixture(false, data);
    }
    
    private void EnableMemoryStreamFixture(bool shouldSeekToRandomPosition, string data)
    {
        Fixture.Register<string, MemoryStream>(_ => 
        {
            var bytes = Encoding.UTF8.GetBytes(data);
            var ms = new MemoryStream(bytes);

            if (shouldSeekToRandomPosition)
            {
                var randomPosition = _random.Next(1, bytes.Length);
                ms.Seek(randomPosition, SeekOrigin.Current); 
            }
            
            return ms;
        });
    }
}