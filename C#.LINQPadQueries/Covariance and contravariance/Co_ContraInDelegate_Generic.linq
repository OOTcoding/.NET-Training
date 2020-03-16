<Query Kind="Program" />

static void Main() 
{
	Base b = new Base();
	
	Derived d = new Derived();
	Base b1 = d;
	
	CustomDelegate dl1 = Method;// similarly new CustomDelegate(Method);
	
	CovariantAndContravariandDelegate del = new CovariantAndContravariandDelegate(dl1); // create new delegate-object
	// CovariantAndContravariandDelegate del = Method;

	Func<Base, Derived> f1 = Method;// similarly new Func<Base, Derived>(Method);
	
	Func<Derived, Base> f2 = f1;
}


//public delegate TResult Func<in T, out TResult>(T arg);

public class Base { }

public class Derived : Base { }

public delegate Base CovariantAndContravariandDelegate(Derived derived);

public delegate Derived CustomDelegate(Base derived);

public static Derived Method(Base b) => b as Derived ?? new Derived();