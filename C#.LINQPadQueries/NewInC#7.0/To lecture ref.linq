<Query Kind="Program">
  <Namespace>System.Data.Entity</Namespace>
</Query>

void Main()
{
	int[] data = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
	data.Dump();
	ref int value = ref ElementAt(data, 2);
	value = 11;
	data.Dump();

	ElementAt(data, 2) = 33;
	data.Dump();
	int value1 = ElementAt(data, 2);
	value1 = 22;
	data.Dump();
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
