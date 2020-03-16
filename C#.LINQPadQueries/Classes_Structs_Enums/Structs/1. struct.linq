<Query Kind="Program" />

public struct Point
{
	public int x, y;
	//public int x = 0, y = 0;  // Illegal: cannot initialize field
	//public Point()	{ }		// Illegal: cannot have parameterless constructor
	public Point (int x, int y) // Illegal: must assign field y
	{ 
		this.x = x; 
		// this.y = y;
	}
}

static void Main()
{
	Point p1 = new Point ();       // p1.x and p1.y will be 0
	p1.Dump();
	
	Point p2 = new Point (1, 1);   // p1.x and p1.y will be 1
	p2.Dump();
}