<Query Kind="Program" />

void Main()
{

	int[] foo = new int[100];
	for (int num = 0; num < foo.Length; num++)
		foo[num] = num * num;
//	foreach (int i in foo)
//		Console.WriteLine(i.ToString());
}

//vs

//Enumerable.Range(0, 100).Select(t => t * t).ToList().ForEach(t => Console.WriteLine(t));

//You need to generate (X,Y) pairs for all integers from 0 through 99
//=========================
private static IEnumerable<Tuple<int, int>> ProduceIndices()
{
	for (int x = 0; x < 100; x++)
		for (int y = 0; y < 100; y++)
			yield return Tuple.Create(x, y);
}
//vs
private static IEnumerable<Tuple<int, int>> QueryIndices()
{
	return from x in Enumerable.Range(0, 100)
		   from y in Enumerable.Range(0, 100)
		   select Tuple.Create(x, y);
}
//==========================
//to generating only those pairs where the sum of X and Y is less than 100
private static IEnumerable<Tuple<int, int>> ProduceIndices2()
{
	for (int x = 0; x < 100; x++)
		for (int y = 0; y < 100; y++)
			if (x + y < 100)
				yield return Tuple.Create(x, y);
}
//vs
private static IEnumerable<Tuple<int, int>> QueryIndices2()
{
	return from x in Enumerable.Range(0, 100)
		   from y in Enumerable.Range(0, 100)
		   where x + y < 100
		   select Tuple.Create(x, y);
}
//===========================
//you must return the points in decreasing order based on their distance from the origin
private static IEnumerable<Tuple<int, int>> ProduceIndices3()
{
	var storage = new List<Tuple<int, int>>();
	
	for (int x = 0; x < 100; x++)
		for (int y = 0; y < 100; y++)
			if (x + y < 100)
				storage.Add(Tuple.Create(x, y));
				
	storage.Sort((point1, point2) =>
		(point2.Item1 * point2.Item1 +
		 point2.Item2 * point2.Item2).CompareTo(
		point1.Item1 * point1.Item1 +
		point1.Item2 * point1.Item2));
	return storage;
}
//vs
private static IEnumerable<Tuple<int, int>> QueryIndices3()
{
	return from x in Enumerable.Range(0, 100)
		   from y in Enumerable.Range(0, 100)
		   where x + y < 100
		   orderby (x * x + y * y) descending
		   select Tuple.Create(x, y);
}