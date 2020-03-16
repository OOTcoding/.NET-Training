<Query Kind="Program" />

public class Point
{
	public double x = 0.0, y = 0.0;
	public static int z = 1;

	public Point() { }

	public Point(double x, double y)
	{
		this.x = x;
		//this.y = y;
	}
}

public struct Point2D
{
	// public double x = 0.0, y = 0.0; <- CTE
	public double x, y;
	public static int z = 1;

	// public Point2D() { } <- CTE

	//	public Point2D(double x, double y)
	//	{
	//		this.x = x;
	//		//this.y = y; <- CTE
	//	}

	public Point2D(double x, double y)
	{
		this.x = x;
		this.y = y;
	}

	//	public Point2D(double x, double y) : this(x, y)
	//	{
	//	}
}

static void Main()
{
	Point p1 = new Point();       // p1.x and p1.y will be 0
	p1.Dump();

	Point2D p2 = new Point2D(1, 1);   // p1.x and p1.y will be 1
	p2.Dump();
}