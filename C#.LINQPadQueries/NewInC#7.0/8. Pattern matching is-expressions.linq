<Query Kind="Statements" />

// We can now test for type and introduce a variable at the same time:
//Examples of patterns in C# 7.0 are:

//Constant patterns of the form c (where c is a constant expression in C#), 
//which test that the input is equal to c

//Type patterns of the form T x (where T is a type and x is an identifier),
//which test that the input has type T, and if so, extracts the value 
//of the input into a fresh variable x of type T

//Var patterns of the form var x (where x is an identifier), 
//which always match, and simply put the value of the input into a
//fresh variable x with the same type as the input.

//Is-expressions with patterns

object foo = "Hello, world";

if (foo is "Hello, world")
{
	"Hello, world".Dump();
}

if (foo is string s)
	s.Length.Dump();
	
object o = null;
int y = 8;
if (o is null) "null".Dump();// constant pattern "null"
if (!(o is int i)) "o is not integer".Dump();// type pattern "int i"
if (y is int x) "y is integer".Dump();// type pattern "int i"
x.Dump();

//if (o is int i || (o is string s && int.TryParse(s, out i)) { /* use i */ }

