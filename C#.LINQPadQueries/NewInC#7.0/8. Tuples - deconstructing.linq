<Query Kind="Program" />

void Main()
{
	// We can "deconstruct" a tuple into individual variables as follows:
	
	(string s, DateTime dt) = Foo();
	
	s.Dump();
	dt.Dump();
	
	// If the variables already exist, just omit the type names:
	
	(s, dt) = Foo();
	
	// You can implicitly type the variables if desired:
	
	var (s2, dt2) = Foo();
	
	s2.Dump();
	dt2.Dump();
	
	// You can discard a tuple member with an underscore:

	var (s3, _) = Foo();
	s3.Dump();
}

(string, DateTime) Foo() => ("Now", DateTime.Now);