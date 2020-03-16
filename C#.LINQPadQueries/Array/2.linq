<Query Kind="Statements" />

//Массивы можно создать двумя способами. 
//Первый – массив создается с помощью оператора new и квадратных скобок. 
//Второй способ – с использованием методов CreateInstance, принадлежащих классу Array. 

int[] array = new int[5];
array[1] = 1;
array.Dump("array");
array.GetType().Dump();
Array array1 = Array.CreateInstance(typeof(Int32), 5);
//array = array1;
array1.GetType().Dump();
array1.SetValue(12,1);

int[] array2 = (int[])Array.CreateInstance(typeof(Int32), 5);

//Для реализации универсального алгоритма (generic-алгоритм) работы с массивами 
//применяются методы GetValue и SetValue класса Array (базового класса 
//всех встроенных массивов).
array1.SetValue(45,1);
//array1[1] = 45;
array2[1] = 22;
array1.Dump("array1");
array2.Dump("array2");