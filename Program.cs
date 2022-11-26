var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<AtomicLong>(new AtomicLong());
var app = builder.Build();

app.MapGet("/greeting", GreetingMapping);

app.Run();

Greeting GreetingMapping(AtomicLong atomicLong, string name = "World")
    => new Greeting(atomicLong.IncrementAndGet(), $"Hello, {name}");

record Greeting(long Id, string Content);

public class AtomicLong
{
    private long _value = 0;
    public long IncrementAndGet() 
        => Interlocked.Increment(ref _value);
}