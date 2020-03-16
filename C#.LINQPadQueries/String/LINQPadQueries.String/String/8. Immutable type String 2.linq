<Query Kind="Statements" />

var s = "Strings are immutable";
int length = s.Length;
var method = typeof(string).GetMethod("InternalSetCharNoBoundsCheck", BindingFlags.Instance | BindingFlags.NonPublic);
for (int i = 0; i < length / 2; i++)
  {
	var temp = s[i];
	method.Invoke(s, new object[] { i, s[length - i - 1] });
	method.Invoke(s, new object[] { length - i - 1, temp });
}

Console.WriteLine("Strings are immutable");