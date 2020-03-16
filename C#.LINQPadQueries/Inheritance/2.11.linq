<Query Kind="Program">
  <Namespace>System.Data.Entity</Namespace>
</Query>

void Main()
{
	SimpleType<int> t = new UserQuery.SimpleType<int>();
	SimpleType<int> t1 =  t.Clone();
}

interface IDo<T> : IDo
{
	//...
	T Do();
}

interface IDo
{
	object Do();
}

public sealed class SimpleType<T> : IDo<T>, ICloneable where T : new
{
	public SimpleType<T> Clone()
	{
		return new SimpleType<T>();
	}

	object ICloneable.Clone()
	{
		return new SimpleType<T>();
	}

	public T Do()
	{
		return new T();
	}

	object IDo.Do()
	{
		return Do();
	}
}