<Query Kind="Program" />

void Main()
{
	SomeClass p1 = new SomeClass(0.5, 1, "Hi");
	SomeClass p2 = new SomeClass(0.5, 1, "Hi");
	Console.WriteLine($"p1 == p2 -> {p1 == p2}");
	Console.WriteLine($"p1.Equals(p2) -> {p1.Equals(p2)}");
	Console.WriteLine($"Equals(p1, p2) -> {Equals(p1, p2)}");
	Console.WriteLine($"ReferenceEquals(p1, p2) -> {ReferenceEquals(p1, p2)}");
	Console.WriteLine($"p1.GetHashCode() == p2.GetHashCode() -> {p1.GetHashCode() == p2.GetHashCode()}");
	Console.WriteLine();
	SomeClass p3 = p1;
	Console.WriteLine($"p1 == p3 -> {p1 == p3}");
	Console.WriteLine($"p1.Equals(p3) -> {p1.Equals(p3)}");
	Console.WriteLine($"Equals(p1, p3) -> {Equals(p1, p3)}");
	Console.WriteLine($"ReferenceEquals(p1, p3) -> {ReferenceEquals(p1, p3)}");
	Console.WriteLine($"p1.GetHashCode() == p3.GetHashCode() -> {p1.GetHashCode() == p3.GetHashCode()}");
	Console.WriteLine();
	SomeClass p4 = new SomeClass(0.5, 1, "Hello");
	Console.WriteLine($"p1 == p4 -> {p1 == p4}");
	Console.WriteLine($"p1.Equals(p4) -> {p1.Equals(p4)}");
	Console.WriteLine($"Equals(p1, p4) -> {Equals(p1, p4)}");
	Console.WriteLine($"ReferenceEquals(p1, p4) -> {ReferenceEquals(p1, p4)}");
	Console.WriteLine($"p1.GetHashCode() == p4.GetHashCode() -> {p1.GetHashCode() == p4.GetHashCode()}");
	Console.WriteLine();
	SomeStruct pp1 = new SomeStruct(0.5, 1, "Hi");
	SomeStruct pp2 = new SomeStruct(0.5, 1, "Hi");
	Console.WriteLine($"pp1 == pp2 -> {pp1 == pp2}");
	Console.WriteLine($"pp1.Equals(pp2) -> {pp1.Equals(pp2)}");
	Console.WriteLine($"Equals(pp1, pp2) -> {Equals(pp1, pp2)}");
	Console.WriteLine($"ReferenceEquals(pp1, pp2) -> {ReferenceEquals(pp1, pp2)}");
	Console.WriteLine($"pp1.GetHashCode() == pp2.GetHashCode() -> {pp1.GetHashCode() == pp2.GetHashCode()}");
	Console.WriteLine();
	SomeStruct pp3 = pp1;
	Console.WriteLine($"pp1 == pp3 -> {pp1 == pp3}");
	Console.WriteLine($"pp1.Equals(pp3) -> {pp1.Equals(pp3)}");
	Console.WriteLine($"Equals(pp1, pp3) -> {Equals(pp1, pp3)}");
	Console.WriteLine($"ReferenceEquals(pp1, pp3) -> {ReferenceEquals(pp1, pp3)}");
	Console.WriteLine($"pp1.GetHashCode() == pp3.GetHashCode() -> {pp1.GetHashCode() == pp3.GetHashCode()}");
	Console.WriteLine();
	SomeStruct pp4 = new SomeStruct(0.5, 1, "Hello");
	Console.WriteLine($"pp1 == pp4 -> {pp1 == pp4}");
	Console.WriteLine($"pp1.Equals(pp4) -> {pp1.Equals(pp4)}");
	Console.WriteLine($"Equals(pp1, pp4) -> {Equals(pp1, pp4)}");
	Console.WriteLine($"ReferenceEquals(pp1, pp4) -> {ReferenceEquals(pp1, pp4)}");
	Console.WriteLine($"pp1.GetHashCode() == pp4.GetHashCode() -> {pp1.GetHashCode() == pp4.GetHashCode()}");
	Console.WriteLine();
	int i1 = new int();
	i1 = 12;
	int i2 = i1;
	Console.WriteLine($"i1 == i2 -> {i1 == i2}");
	Console.WriteLine($"i1.Equals(i2) -> {i1.Equals(i2)}");
	Console.WriteLine($"Equals(i1, i2) -> {Equals(i1, i2)}");
	Console.WriteLine($"ReferenceEquals(i1, i2) -> {ReferenceEquals(i1, i2)}");
	Console.WriteLine($"i1.GetHashCode() == i2.GetHashCode() -> {i1.GetHashCode() == i2.GetHashCode()}");
	Console.WriteLine();
}

class SomeClass
{
	double x;
	int y;
	string s;
	
	public SomeClass(double x, int y, string s)
	{
		this.x = x; this.y = y;this.s = s;
	}
}

struct SomeStruct
{
	double x;
	int y;
	string s;

	public SomeStruct(double x, int y, string s)
	{
		this.x = x; this.y = y;this.s = s;
	}
}
