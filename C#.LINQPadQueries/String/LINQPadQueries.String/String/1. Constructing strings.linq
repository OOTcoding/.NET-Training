<Query Kind="Statements" />

// String literals:
string s1 = "Hello";
string s2 = "First Line\r\nSecond Line";
string s3 = "С:\\Windows\\System32\\Notepad.exe";
string s4 = @"C:\Windows\System32\Notepad.exe";
int number = 10;
string s5 = $"Number is equal {number}";

//Размер строки = 4 * ((14 + 2 * length + 3) / 4) (деление естественно целочисленное)
////https://habr.com/ru/post/172627/

//string s = new string("Hi there.");  //CTE
//System.String s = new System.String("Hi there."); //CTE

// To create a repeating sequence of characters you can use string’s constructor:
(new string ('*', 10)).Dump();    // **********

// You can also construct a string from a char array. ToCharArray does the reverse:
char[] ca = "Hello".ToCharArray();
string s = new string (ca);              // s = "Hello"
s.Dump();

Process.Start(@"C:\Users\Master\Desktop\ildasm.exe", Assembly.GetExecutingAssembly().Location);


