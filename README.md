# MinimalApiVsSpringExample
This is the result of a simple experiment of rewriting (this Spring example)[https://spring.io/guides/gs/rest-service/] in a more condensed way in C#/.NET.

In the Spring example, a very (very) simple API is implemented. It returns greetings in response to HTTP GET requests based on an optional query parameter. The results also contain the value of an atomically incremented counter.

The outcome demonstrates some of the ways the ASP.NET framework and the .NET platform 
in general enables the implementation of very high-level convention-based API development. 

## Records
One C# construct, which saves many lines of codes for this example is the relatively new _record_: In the Spring example, the schema for the results is expressed in a plain-ol' Java class:

```java
package com.example.restservice;

public class Greeting {

	private final long id;
	private final String content;

	public Greeting(long id, String content) {
		this.id = id;
		this.content = content;
	}

	public long getId() {
		return id;
	}

	public String getContent() {
		return content;
	}
}
```

In this C#-based example, the same contract is more condensely expressed using a record:
```C#
record Greeting(long Id, string Content);
```

__Disclaimer__: I am by no means a Spring expert, so there might be simpler ways to do this in Spring as well. I was merely curious to take the Spring example as a starting point to explore how some of the newer ASP.NET features could be applied to this simple example.

