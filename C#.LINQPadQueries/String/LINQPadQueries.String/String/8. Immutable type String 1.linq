<Query Kind="Statements" />

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