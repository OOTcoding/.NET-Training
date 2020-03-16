<Query Kind="Program" />

void Main()
{

	#region Boxing scenatio Value types
	int i = 5;
	int j = 5;
	if (Object.ReferenceEquals(i, j))
		Console.WriteLine("Never happens.");
	else
		Console.WriteLine("Always happens.");
	if (Object.ReferenceEquals(i, i))
		Console.WriteLine("Never happens.");
	else
		Console.WriteLine("Always happens.");
	#endregion

	//Test:
	object baseObject = new B(1);
	object derivedObject = new D(1,2);
	baseObject.Equals(derivedObject);
	derivedObject.Equals(baseObject);
	// Comparison 1.
	if (baseObject.Equals(derivedObject))
		Console.WriteLine("Equals");
	else
		Console.WriteLine("Not Equal");
	// Comparison 2.
	if (derivedObject.Equals(baseObject))
		Console.WriteLine("Equals");
	else
		Console.WriteLine("Not Equal");
}

//Pattern for Equals
public class Foo : IEquatable<Foo>
{
	public override bool Equals(object other)
	{
		// check null:
		// this pointer is never null in C# methods.
		if (object.ReferenceEquals(other, null))
			return false;
		if (object.ReferenceEquals(this, other))
			return true;
		// Discussed below.
		if (this.GetType() != other.GetType())
			return false;
		// Compare this type's contents here:
		return this.Equals(other as Foo);
	}

	//+GetHashCode

	#region IEquatable<Foo> Members
	public bool Equals(Foo other)
	{
		if (object.ReferenceEquals(other, null))
			return false;
			
		if (object.ReferenceEquals(this, other))
			return true;
			
		return true;
	}
	#endregion
}

//Equality is reflexive, symmetric, and transitive. 
//You’ve broken the symmetric property of Equals.
public class B : IEquatable<B>
{
	private int field1;
	
	public B(int field1)
	{
		this.field1 = field1;
	}
	
	public override bool Equals(object other)
	{
		// check null:
		if (object.ReferenceEquals(other, null)) return false;

		// Check reference equality:
		if (object.ReferenceEquals(this, other)) return true;

		// Problems here, discussed below.
		B otherAsB = other as B;//You’ve broken the symmetric property of Equals.
		if (otherAsB == null) return false;

		return this.Equals(otherAsB);
	}

	#region IEquatable<B> Members
	public bool Equals(B other)
	{
		if (object.ReferenceEquals(other, null)) return false;

		if (object.ReferenceEquals(this, other)) return true;
		
		return this.field1 == other.field1;
	}
	#endregion
}

public class D : B, IEquatable<D>
{
	private int field2;
	
	public D(int field1, int field2) : base(field1)
	{
		this.field2 = field2;
	}
	// etc. 
	public override bool Equals(object right)
	{
		// check null:
		if (object.ReferenceEquals(right, null)) return false;

		if (object.ReferenceEquals(this, right)) return true;

		// Problems here.
		D rightAsD = right as D;
		if (rightAsD == null) return false;

		if (base.Equals(rightAsD) == false) return false;
		return this.Equals(rightAsD);
	}

	#region IEquatable<D> Members
	public bool Equals(D other)
	{
		if (object.ReferenceEquals(other, null)) return false;

		if (object.ReferenceEquals(this, other)) return true;
		
		return base.Equals(other) && this.field2 == other.field2;
	}
	#endregion
}
//public static bool ReferenceEquals(object left, object right);
//public static bool Equals(object left, object right);
//public virtual bool Equals(object right);
//public static bool operator ==(SameClass left, SameClass right);

//The static Object.Equals() method is implemented something like this:
public static new bool Equals(object left, object right)
{
	// Check object identity
	if (Object.ReferenceEquals(left, right))
		return true;
	// both null references handled above
	if (Object.ReferenceEquals(left, null) ||
		   Object.ReferenceEquals(right, null))
		return false;
	return left.Equals(right);
}

//You come to IStructuralEquality, which is implemented on System.Array and the Tuple<> generic classes.

//C# gives you numerous ways to test equality, but you need to consider providing '
//your own definitions for only two of them, along with supporting the analogous interfaces.
//You never override the static Object.ReferenceEquals() and static Object.Equals() 
//because they provide the correct tests, regard- less of the runtime type. '
//You always override instance Equals() and operator ==() for value types to provide
//better performance. You override instance Equals() for reference types when you 
//want equality to mean something other than object identity. Anytime you override 
//Equals() you implement IEquatable<T>.
