<Query Kind="Program">
  <Namespace>System.Data.Entity</Namespace>
</Query>

class FieldLikeSingleton
{
	public static FieldLikeSingleton Instance { get; } = new FieldLikeSingleton();

	// static FieldLikeSingleton(){ }
	
	private FieldLikeSingleton()
	{
		Console.WriteLine("FieldLikeSingleton.ctor");
	}

	public void Foo()
	{
		Console.WriteLine("Foo");
	}
}

class Program
{
	static void Main(string[] args = null)
	{
		Console.WriteLine("Inside Main()");
		if (args != null)
		{
			FieldLikeSingleton.Instance.Foo();
		}
	}
}