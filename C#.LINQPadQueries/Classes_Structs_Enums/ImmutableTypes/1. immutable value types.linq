<Query Kind="Program" />

void Main()
{
	A a = new A();
	//a.Mutable.Y++;
	//значение структуры Mutable копируется 
	//при возвращении из одноименного свойства
	a.Mutable.X.Dump("Before call");
	a.Mutable.IncrementX();
	a.Mutable.IncrementX();
	a.Mutable.IncrementX();
	a.Mutable.X.Dump("After three call Increment");

}

// Значимые типы являются значениями, которые копируются
// каждый раз при передаче в функцию или при возвращении из нее.

struct Mutable
{
	public Mutable(int x, int y) : this()
	{
		X = x;
		Y = y;
	}
	public void IncrementX() => X++;
	public int X { get; private set; }
	public int Y { get; set; }
}

class A
{
	public A() => Mutable = new Mutable(x: 5, y: 5);
	//значение структуры Mutable копируется при возвращении
	//из одноименного свойства!
	public Mutable Mutable { get; private set; }
}