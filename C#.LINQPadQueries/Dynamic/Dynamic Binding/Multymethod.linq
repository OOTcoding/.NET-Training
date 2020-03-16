<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

#region Multimethod
// Мультиметод (multimethod)
// множественная диспетчеризация (multiple dispatch) 
// механизм, позволяющий выбрать на рантайме одну из нескольких функций 
// в зависимости от динамических типов или значений аргументов. 
// Представляет собой расширение одиночной диспетчеризации 
// (виртуальных функций), где выбор метода осуществляется 
// динамически на основе фактического типа объекта. 
// Множественная диспетчеризация обобщает динамическую 
// диспетчеризацию для случаев с двумя или более объектами.
#endregion

public class Thing { }

public class Asteroid : Thing { }

public class Spaceship : Thing { }

public static class ThingExtentions
{
	public static void CollideWith(Thing x, Thing y)
	{
		// no dynamic dispatch
		CollideWithImplementation(x, y);
		"---".Dump();
		dynamic a = x;
		dynamic b = y;
		// dynamic dispatch
		CollideWithImplementation(a, b);
		"---".Dump();
	}

	static void CollideWithImplementation(Thing x, Thing y)
	{
		"нечто сталкивается с чем-то".Dump();
	}

	static void CollideWithImplementation(Asteroid x, Asteroid y)
	{
		"астероид сталкивается с астероидом".Dump();
	}

	static void CollideWithImplementation(Asteroid x, Spaceship y)
	{
		"астероид сталкивается с космическим кораблем".Dump();
	}

	static void CollideWithImplementation(Spaceship x, Asteroid y)
	{
		"космический корабль сталкивается с астероидом".Dump();
	}

	static void CollideWithImplementation(Spaceship x, Spaceship y)
	{
		"космический корабль сталкивается с космическим кораблем".Dump();
	}

}

void Main()
{
	Thing asteroid = new Asteroid();
	Thing spaceship = new Spaceship();
	Thing thing = new Thing();
	ThingExtentions.CollideWith(asteroid, spaceship);
	ThingExtentions.CollideWith(spaceship, spaceship);
	ThingExtentions.CollideWith(asteroid, asteroid);
	ThingExtentions.CollideWith(thing, asteroid);
	ThingExtentions.CollideWith(spaceship, thing);
}