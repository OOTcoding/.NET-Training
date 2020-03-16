<Query Kind="Program">
  <Namespace>System.Data.Entity</Namespace>
</Query>

void Main()
{
	A a = new A();
	A b = new A("Joe",11);
}

class A
{
	public string name = "Tim";
	public int age = 20;

	public A()
	{ 

	}

	public A(string name, int age)
	{
		this.name = name;
		this.age = age;
	}
}

//<=>
//class A
//{
//	public string name;
//	public int age;
//
//	public A()
//	{
//		this.name = "Tim";
//		this.age = 20;
//		base..ctor();
//	}
//
//	public A(string name, int age)
//	{
//		this.name = "Tim";
//		this.age = 20;
//		base..ctor();
//		this.name = name;
//		this.age = age;
//	}
//}