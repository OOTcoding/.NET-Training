<Query Kind="Program" />

static void Main() 
{
	Func<Base, Derived> f1 = Method;
	Derived d = f1(new Base());
	d.Dump();
	Func<Derived, Base> f2 = f1;
	Base b = f2(new Derived());
	
	CovariantAndContravariandDelegate del = new CovariantAndContravariandDelegate(Do);
	// create new delegate-object
	// similarly
	// CovariantAndContravariandDelegate del = Do;
}


//public delegate TResult Func<in T, out TResult>(T arg);

public class Base { }
public class Derived : Base { }

public delegate Base CovariantAndContravariandDelegate(Derived derived);
public delegate Derived CustomDelegate(Base derived);


public static Derived Method(Base b) => b as Derived ?? new Derived();