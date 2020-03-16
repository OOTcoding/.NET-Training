<Query Kind="Program" />

void Main()
{
	Fibonacci (47).Dump();
}

public IEnumerable<int> Fibonacci (int x)
{
	int j = 0;
	while(j < x)
	{
		yield return Fib (j).current;
		j++;
	}
	
	// You can now declare a function within a function:

	(int current, int previous) Fib (int i)
	{
		if (i == 0) return (1, 0);
		var (p, pp) = Fib (i - 1);
		return (p + pp, p);
	}
}

// (This also works with iterators)