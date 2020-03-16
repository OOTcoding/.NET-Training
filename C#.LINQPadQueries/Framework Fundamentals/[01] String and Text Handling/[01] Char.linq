<Query Kind="Statements" />

{
	char ch1 = '\u0033';
	ch1.Dump();
	Char.GetNumericValue(ch1).Dump();
	char ch2 = '\u00bc';
	ch2.Dump();
	Char.GetNumericValue(ch2).Dump();//('¼')
	char ch3 = 'A';
	ch3.Dump();
	Char.GetNumericValue(ch3).Dump();//-1

	int n = 65;
	char c = (char)65;
	c.Dump();

	n = c;
	n.Dump();

	c = Convert.ToChar(65);
	c.Dump();

	n = Convert.ToInt32(c);
	n.Dump();
}

{
	// char literals:
	char c = 'A';
	char newLine = '\n';

	// System.Char defines a range of static methods for working with characters:
	Console.WriteLine(char.ToUpper('c'));               // C
	Console.WriteLine(char.IsWhiteSpace('\t'));     // True
	Console.WriteLine(char.IsLetter('x'));          // True
	Console.WriteLine(char.GetUnicodeCategory('x'));    // LowercaseLetter
}