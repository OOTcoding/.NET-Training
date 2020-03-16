<Query Kind="Program" />

void Main()
{
	Fibonacci (10).Dump();
}

public int Fibonacci (int x)
{
	return Fib (x).current;
	
	// You can now declare a function within a function:

	(int current, int previous) Fib (int i)
	{
		if (i == 0) return (1, 0);
		var (p, pp) = Fib (i - 1);
		return (p + pp, p);
	}
}

// (This also works with iterators)