<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

public static dynamic Foo(dynamic x, dynamic y)
{
	"dynamic->".Dump();
	return x / y;
}

public static int Foo(int x, int y)
{
	"int->".Dump();
	return x / y;
}

public void Main()
{
	Foo("7","3").Dump();
//	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",
//		Assembly.GetExecutingAssembly().Location);
}