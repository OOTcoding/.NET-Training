<Query Kind="Program" />

void Main()
{
	// If you don't need the value of an out parameter, you can discard it with an underscore:
	
	string numberString = Util.ReadLine ("Enter a number");
	
	if (int.TryParse (numberString, out _))   // Discard out argument
		"Valid number".Dump();
	else
		"Invalid number".Dump();

	// You can use the underscore multiple times in a single method call:
	Foo (out int interesting, out _, out _, out _);
	$"The answer to life is {interesting}".Dump();
}

void Foo (out int p1, out string p2, out bool p3, out char p4)
{
	p1 = 42;
	p2 = "fourty two";
	p3 = true;
	p4 = 'x';
}