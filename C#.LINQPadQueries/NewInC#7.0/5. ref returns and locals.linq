<Query Kind="Program" />

// Ref returns/locals are now possible for advanced scenarios.
// See https://blogs.msdn.microsoft.com/dotnet/2016/08/24/whats-new-in-csharp-7-0/

void Main()
{
	int[] array = { 1, 15, -39, 0, 7, 14, -12 };
	array.Dump();
	ref int place = ref Find (7, array); // aliases 7's place in the array
	place.Dump();
	place = 9; // replaces 7 with 9 in the array
	array.Dump();


	int[] data = new int[10];
	ref int value = ref ElementAt(data, 2);
	value = 11;
	data.Dump();

	ElementAt(data, 2) = 13;
	data.Dump();

	int value1 = ElementAt(data, 2);
	value1 = 11;
	data.Dump();
}

public ref int Find (int number, int[] numbers)
{
	
	for (int i = 0; i < numbers.Length; i++)
	{
		if (numbers[i] == number)
		{
			return ref numbers[i]; // return the storage location, not the value
		}
	}
	throw new IndexOutOfRangeException ($"{nameof (number)} not found");
}

static ref T ElementAt<T>(T[] array, int position)
{
	if (array == null)
	{
		throw new ArgumentNullException(nameof(array));
	}
	if (position < 0 || position >= array.Length)
	{
		throw new ArgumentOutOfRangeException(nameof(position));
	}
	return ref array[position];
}
