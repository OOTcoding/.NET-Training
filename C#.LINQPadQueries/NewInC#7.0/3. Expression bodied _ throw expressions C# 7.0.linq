<Query Kind="Program">
  <Namespace>System.Collections.Concurrent</Namespace>
</Query>

//http://www.dotnetcurry.com/csharp/1286/csharp-7-new-expected-features
void Main()
{
	// You can now throw expressions in expressions clauses.
	// This is useful in conditional expressions:

	string result = new Random().Next(2) == 0 ? "Good" : throw new Exception("Bad");
	result.Dump();

	Foo().Dump();
}

public string Foo() => throw new NotImplementedException();//throw expressions

class Person
{
	private static ConcurrentDictionary<int, string> names = new ConcurrentDictionary<int, string>();
	private int id;// = GetId();

	public Person(string name) => names.TryAdd(id, name); // constructors
	~Person() => names.TryRemove(id, out _);              // destructors
	public string Name
	{
		get => names[id];                                 // getters
		set => names[id] = value;                         // setters
	}
}

//Throw expressions
class Person
{
	public string Name { get; }
	public Person(string name) => Name = name ?? throw new ArgumentNullException(name);
	public string GetFirstName()
	{
		var parts = Name.Split();
		return (parts.Length > 0) ? parts[0] : throw new InvalidOperationException("No name!");
	}
	public string GetLastName() => throw new NotImplementedException();
}

interface IEnemy
{
	int Health { get; set; }
}

class Grunt : IEnemy
{
	//Code Simplification in C# 7
    //public Grunt(int health) => this.health = health >= 0 ? health : throw new ArgumentOutOfRangeException();
	//vs
	public Grunt(int health)
	{
		if (health < 0)
			throw new ArgumentOutOfRangeException();
			
		this.health = health;
	}

    ~Grunt() => Debug.WriteLine("Finalizer called");
 
    private int health;
	
    public int Health
	{
		get => health = 0;
		set => health = value >= 0 ? value : 0;
	}
}