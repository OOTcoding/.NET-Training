<Query Kind="Program" />

class Animal { }

class Dog : Animal
{
	public void Woof() { Console.WriteLine ("woof!"); }
}

void Main()
{
	object x = new Dog();
	x.GetType().Dump();
	x.GetType().GetMethod ("Woof").Dump();
	x.GetType().GetMethod ("Woof").Invoke (x, null);
}