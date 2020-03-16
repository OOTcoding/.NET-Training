<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
</Query>

string s = "Это текстовая строка, состоящая из семи слов.";
s.Dump("строка = ");
Console.WriteLine($"Длина строки {s.Length}");
Console.WriteLine($"Наличие подстроки \"текст\" {s.Contains("текст")} ");
Console.WriteLine($"Вставка \"{s.Insert(4, "большая")}\"");
Console.WriteLine($"Длина строки {s.Length} символов");
Console.WriteLine($"Удаление:\"{s.Remove(4, 10)}\"");
Console.WriteLine($"Замена: \"{s.Replace("семи", "нескольких")}\"");
Console.WriteLine($"Подстрока: \"{ s.Substring(4, 5)}\"");
Console.WriteLine($"В верхний регистр: {s.ToUpper()}");
Console.WriteLine($"Вхождение \"текст\": {s.IndexOf("текст")}");
s.Dump("строка = ");