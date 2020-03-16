<Query Kind="Program" />

void Main()
{
	Point location = new Point(10, 10);
	var kid = new Kid();
	kid.Location = location;
	Console.WriteLine($"kid location({kid.Location.X} , {kid.Location.Y})");
	Table table = new Table();
	table.Location = location;
	Console.WriteLine($"table location({table.Location.X} , {table.Location.Y})");
	location.X = 20;
	location.Y = 20;
	Console.WriteLine("table dislocation");
	table.Location = location;
	Console.WriteLine($"table location({table.Location.X} , {table.Location.Y})");
	Console.WriteLine($"kid location({kid.Location.X} , {kid.Location.Y})");
}
class Kid
{
	public Point Location { get; set; }
}

class Table
{
	public Point Location { get; set; }
}

struct Point
{
	public Point(int x, int y)
	{
		this.X = x;
		this.Y = y;
	}

	public int X { get; set; }
	public int Y { get; set; }
}