DynamicDictionary
=================

###What is it?###

A C# single file drop in dynamic dictionary allowing case-insensitive access and returns null when accessing non-existent properties.

###How does this differ from ExpandoObject?###

The .NET Framework provided [System.Dynamic.ExpandoObject](http://msdn.microsoft.com/en-us/library/system.dynamic.expandoobject(v=vs.110).aspx) is the reference example of how to work with dynamic objects and works great for most scenarios.

DynamicDictionary offers an alternative solution for creating and working with dynamics with two key differences:
 - Case-insensitive access to properties or keys
 - Returns null when accessing non-existent properties or keys as opposed to throwing an exception which is the default behavior of most dictionary implementations and the .NET framework provided ExpandoObject.

###Usage###

```csharp
// Non-existent properties will return null
dynamic obj = new DynamicDictionary();
var firstName = obj.FirstName;
Assert.That( firstName == null );

// Allows case-insensitive property access
dynamic obj = new DynamicDictionary();
obj.SuperHeroName = "Superman";
Assert.That( obj.SUPERMAN == "Superman" );
Assert.That( obj.superman == "Superman" );
Assert.That( obj.sUpErMaN == "Superman" );
```

Please see the project unit tests for more examples.

###License###

MIT License:

Copyright (c) 2014 Randy Burden ( http://randyburden.com ) All rights reserved.

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and 
associated documentation files (the "Software"), to deal in the Software without restriction, including 
without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the 
following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial 
portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT 
LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN 
NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE. 
