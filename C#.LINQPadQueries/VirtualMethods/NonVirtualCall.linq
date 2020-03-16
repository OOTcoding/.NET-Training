<Query Kind="Program" />

void Main()
{
	SomeClass obj = new SomeClass();
	obj.Foo();//calvirt?
	obj.ToString();//calvirt?
	int x = 12;
	x.ToString().Dump();//call?
}

class SomeClass
{
	public override string ToString()
	{
		return base.ToString();//call?
	}

	public void Foo() {}
}