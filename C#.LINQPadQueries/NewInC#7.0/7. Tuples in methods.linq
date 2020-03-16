<Query Kind="Program" />

//Out parameters: Use is clunky (even with the improvements described above), 
//and they don’t work with async methods.
//
//System.Tuple <...> return types: Verbose to use and require an allocation of a tuple object.
//
//Custom - built transport type for every method: A lot of code overhead for 
//a type whose purpose is just to temporarily group a few values.
//
//Anonymous types returned through a dynamic return type: High performance 
//overhead and no static type checking.
   

   void Main()
{
	Foo().Item1.Dump();
	Foo().Item2.Dump();
	
	// With named tuples:
	
	NamedFoo().name.Dump();
	NamedFoo().time.Dump();
}

(string, DateTime)            Foo()       => ("Now", DateTime.Now);

(string name, DateTime time)  NamedFoo()  => ("Now", DateTime.Now);