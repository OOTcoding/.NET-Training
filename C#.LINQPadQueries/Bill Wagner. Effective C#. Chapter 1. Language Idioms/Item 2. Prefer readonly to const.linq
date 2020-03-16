<Query Kind="Program" />

//C# has two different versions of constants: compile-time constants and runtime constants.

void Main()
{
	//	This construct:
	//if (myDateTime.Year == Millennium)
	//	compiles to the same IL as if you had written this: 
	//if (myDateTime.Year == 2000)

	//ou cannot initialize a compile-time constant using the new operator,
	//even when the type being initialized is a value type	
	for (int i = UsefulValues.StartValue; i <= UsefulValues.EndValue; i++)
		Console.WriteLine("value is {0}", i);

}

public class SameClass
{	
  	// Compile time constant:
  	public const int Millennium = 2000;

	// Runtime constant:
	public static readonly int ThisYear = 2004;
	
	// Does not compile, use readonly instead:
	//private const DateTime classCreation = new DateTime(2000, 1, 1, 0, 0, 0);
	

}

//public static class UsefulValues
//{
//
//	public static readonly int StartValue = 5;
//	public const int EndValue = 10;
//}

public static class UsefulValues//New vertion
{

	public static readonly int StartValue = 5;
	public const int EndValue = 10;
}