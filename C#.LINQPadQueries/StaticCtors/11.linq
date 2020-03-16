<Query Kind="Program">
  <Namespace>System.Data.Entity</Namespace>
</Query>

void Main()
{
	Derived d = new Derived();
}

class Base
{
	public static int c = 7;
	
	public Base() => "Base ctor".Dump();
	
	// static Base() => "Base cctor".Dump();
	
}

class Derived : Base
{
	public static int d = 9;
	
	public Derived() => "Derived ctor".Dump();

	static Derived() => "Derived cctor".Dump();
}