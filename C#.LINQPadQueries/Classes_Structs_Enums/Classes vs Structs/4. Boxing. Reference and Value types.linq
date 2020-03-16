<Query Kind="Program" />

void Main()
{
	int x = 78;
	IFormattable ft = x;
	ft.Dump();
	
	ValueType vt = x;
	vt.Dump();
	
	object obj = x;
	obj.Dump();
	
	dynamic d = x;
	x.ToString().Dump();
	
	Color color = Color.White
	Enum enm = color;

	//Bar(42);
}

enum Color
{
	Black,
	White
}

static int Bar(object value)
{
	int a = (int)value;
	return a;
}