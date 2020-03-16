<Query Kind="Program" />

void Main()
{
	//object o = Factory.GetObject();
	//object o = Factory.GetDerivedObject();
	object o = Factory.GetSecondObject();//all bad? all bad
	o.Dump();
	//o = null;
	//null can be converted to any reference type using a cast, 
	//but the as operator returns null when used on a null reference!!
	// Version one:
	SameType t = o as SameType;
	//var ok = o is SameType;
	if (t != null)
	{
		"All right!".Dump();
		// work with t, it's a MyType.
	}
	else
	{
		"All bad!".Dump();
	}

	try
	{
		o.Dump();
		SameType t1 = (SameType)(SecondType)o;
		"All right!".Dump();
		// work with T, it's a MyType.
	}
	catch (InvalidCastException)
	{
		// report the conversion failure.
		"All bad!".Dump();
	}
	
}

class SameType 
{ }

class SecondType
{ 
	private SameType value;
	
	public static implicit operator SameType (SecondType t) => t.value;
}

class DerivedSameType : SameType
{ }

static class Factory 
{
	public static SameType GetObject() => new SameType();
	public static DerivedSameType GetDerivedObject() => new DerivedSameType();
	public static SecondType GetSecondObject() => new SecondType();
}