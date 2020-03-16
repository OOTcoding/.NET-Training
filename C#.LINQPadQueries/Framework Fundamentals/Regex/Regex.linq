<Query Kind="Statements" />

//Albahari J., Albahari B. - C# 6.0 in a Nutshell, 6th Edition - 2015
//Chapter 26 Regular Expression
//квантификатор ?
Console.WriteLine (Regex.Match ("color", @"colou?r").Success); 
Console.WriteLine (Regex.Match ("colour", @"colou?r").Success);
Console.WriteLine (Regex.Match ("colouur", @"colou?r").Success);

Match m = Regex.Match("any colour you like", @"colou?r");
Console.WriteLine(m.Success);
Console.WriteLine(m.Index); 
Console.WriteLine(m.Length); 
Console.WriteLine(m.Value); 
Console.WriteLine(m.ToString());

Match m1 = Regex.Match("One color? There are two colours in my head!",@"colou?rs?");
Match m2 = m1.NextMatch();
m1.Dump();//Console.WriteLine(ml);
m2.Dump();//Console.WriteLine(m2);

foreach (Match m3 in Regex.Matches("One color? There are two colours in my head!", @"colou?rs?"))
{
	Console.WriteLine(m3);
}

//перестановка
Console.WriteLine (Regex.IsMatch ("Jenny", "Jen(ny\nifer)?"));
Console.WriteLine (Regex.IsMatch ("Jennifer", "Jen(ny\nifer)?"));
//RegexOptions
Console.WriteLine(Regex.Match("а", "А", RegexOptions.IgnoreCase));
Console.WriteLine(Regex.Match("а", "А", RegexOptions.IgnoreCase|RegexOptions.CultureInvariant));
Console.WriteLine (Regex.Match ("а", @"(?i)A"));
Console.WriteLine (Regex.Match (" а", @"(?i)a(?-i)a"));