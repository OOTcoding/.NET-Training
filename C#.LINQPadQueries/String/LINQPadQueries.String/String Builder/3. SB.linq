<Query Kind="Program" />

void Main()
{
	const string input = "abcdefghijklmnopqrstuvwxyz";
	int length = input.Length;

	#region Append 
	//Метод Append() работает следующим образом: 
	//если в текущем элементе списка хватает символов для вставки новой строки,
	//то происходит копирование в нее, если же нет, то копируется та часть 
	//которая помещается, а для того, что не поместилось, создается
	//новый элемент списка (экземпляр StringBuilder-a), у которого длина
	//массива равна длине всей исходной строки либо длине оставшейся строки
	//в зависимости от того что больше. Однако, максимальная длина массива составляет 8000.
	//int length = Math.Max(minBlockCharCount, Math.Min(this.Length, 8000))
	// длины массивов у элементов списка будут равны:
	// 8000, 4092, 2048, 1024, 512, 256, 128, 64, 32, 16, 16.
	// При таких длинах массивов операция обращения к определенному 
	// символу в исходной строке выполняется достаточно быстро практически 
	// за O(1), так как элементов списка не так много. 
	#endregion
	
	StringBuilder sbAppend = new StringBuilder();
	for (int i = 0; i < 100; i++)
	{
		//sbAppend.Append(input[i % length]);
		sbAppend.Append(input);
		//sb.Capacity.Dump($"{i+1} = ");
	}
	sbAppend.Clear();
	//sb.Capacity.Dump();

	#region Insert description
	//Метод Insert() работает следующим образом: если в текущем элементе списка 
	//(StringBuilder-е) хватает места для вставки, то имеющиеся символы сдвигаются,
	//чтобы дать место новому тексту. Иначе же создается новый элемент списка
	//(StringBuilder), в который копируется часть символов из предыдущего элемента,
	//которые не поместились. Последующие символы не смещаются влево.
	//Получим очень большой список StringBuilder-ов каждый элемент, 
	//которого будет иметь длину 16 символов. В результате чего операция
	//обращения к определенному символу по индексу будет выполняться медленней, 
	//чем ожидалось, а именно пропорционально длине списка, то есть O(n). 
	#endregion
	
	StringBuilder sbInsert = new StringBuilder(input);
	for (int i = 0; i < 100; i++)
	{
		//sbInsert.Insert(0, input[i % length]);
		sbInsert.Insert(3, input);
		//sbInsert.Capacity.Dump($"{i+1} = ");
	}
}
