<Query Kind="Program" />

void Main()
{
	
	Mutable mutable = new Mutable();
	mutable.Name = "Mutable struct";
	mutable.value = 12;
	mutable.Dump();
	object obj = mutable;

	Immutable immutable = new Immutable();
	//immutable.name = "Immutable struct";//CTE
	//immutable.value = 12;//CTE
	immutable.Dump();
	obj = immutable;

	StackAlloc stackallocation = new StackAlloc();
	//immutable.name = "Immutable struct";//CTE
	//immutable.value = 12;//CTE
	stackallocation.name = "Stack allocation struct";
	stackallocation.value = 90;
	//obj = stackallocation;//CTE only in stack
	//Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",Assembly.GetExecutingAssembly().Location);
}

struct Mutable
{
	public int value;
	public string Name { get; set; }

	public Mutable(int value, string name)
	{
		this.Name = name;
		this.value = value;
	}
}

readonly struct Immutable
{
	public readonly int value;
	public readonly string name;
	
	public Immutable(int value, string name)
	{
		this.name = name;
		this.value = value;
	}
}

ref struct StackAlloc
{
	public int value;
	public string name;

	public StackAlloc(int value, string name)
	{
		this.name = name;
		this.value = value;
	}
}

class Wrapper
{
	//public StackAlloc stckall = default; 
}