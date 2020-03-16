<Query Kind="Statements" />

int? nullable = 5;

object boxed = nullable;
Console.WriteLine(boxed.GetType());

int normal = (int)boxed;
Console.WriteLine(normal);
Console.WriteLine(normal.GetType());

nullable = (int?)boxed;
Console.WriteLine(nullable);

nullable = new Nullable<int>();
//Console.WriteLine(nullable.GetType());<-RTE
boxed = nullable;
Console.WriteLine(boxed == null);

nullable = (int?)boxed;
Console.WriteLine(nullable.HasValue);

normal = (int)boxed;
Console.WriteLine(nullable.HasValue);