<Query Kind="Program" />

// Deconstructors are not just for tuples.
// You can create your own by writing a method called "Deconstruct".

void Main()
{
	var point = new Point (3, 4);
	point.Dump("point=");
	var (x, y) = point;
	
	x.Dump("x=");
	y.Dump("y=");
}

class Point
{
    public int X { get; }
    public int Y { get; }

    public Point (int x, int y) { X = x; Y = y; }
    public void Deconstruct (out int x, out int y) { x = X; y = Y; }
}