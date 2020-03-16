<Query Kind="Program" />

//https://habr.com/ru/post/224281/
void Main()
{
	//CompilationRelaxationsAttribute -> CompilationRelaxations.NoStringInterning 
	//[assembly:CompilationRelaxations(CompilationRelaxations.NoStringInterning)]
	//Интернирование строк — это механизм, при котором одинаковые 
	//литералы представляют собой один объект в памяти.

	var s = "Strings are immutable";
	s.Dump("before");
	int length = s.Length;
	unsafe
	{
		fixed (char* c = s)
		{
			for (int i = 0; i < length / 2; i++)
			{
				var temp = c[i];
				c[i] = c[length - i - 1];
				c[length - i - 1] = temp;
			}
		}
	}
	s.Dump("after");
	"Strings are immutable".Dump("?");

	string str = string.Empty;
	string str1 = string.Empty;
	object.ReferenceEquals(str,str1).Dump();
	StringBuilder sb = new StringBuilder().Append(String.Empty);
	//string str2 = string.Intern(sb.ToString());
	string str2 = sb.ToString();

	if (object.ReferenceEquals(str1, str2))
		Console.WriteLine("Equal");
	else
		Console.WriteLine("Not Equal");

	//	Process.Start(@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",
	//	Assembly.GetExecutingAssembly().Location);

	//	Process.Start(@"C:\Users\Master\Desktop\ildasm.exe",
	//	Assembly.GetExecutingAssembly().Location);

}

// Define other methods and classes here
