<Query Kind="Program" />

void Main()
{
	Function<object, object, string> f = new UserQuery.Function<object, object, string>(Foo);
	Function<string, string, object> g = f;
	f("","").Dump();
	g("","").Dump();
}

public delegate TResult Function<in T1, in T2, out TResult>(T1 item1, T2 item2);

public string Foo(object obj1, object obj2) => "Co&ContraVariance";