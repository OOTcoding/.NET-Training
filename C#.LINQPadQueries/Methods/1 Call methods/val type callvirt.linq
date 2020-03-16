<Query Kind="Program" />

void Main()
{
	Point point = new Point();
	point.Dump();
	point.Equals(point).Dump();
	point.ToString().Dump();
}

//http://epetrukhin.blogspot.com.by/2011/04/call-vs-callvirt-1.html

struct Point
{
	public double X { get; set; }
	public double Y { get; set; }

	override public bool Equals(object other) => true;
	
	override public string ToString() => "";
}