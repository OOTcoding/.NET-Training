<Query Kind="Program" />

//One day, you’ll create a type that is meant to be used as a hash key, 
//and you’ll need to write your own implementation of GetHashCode(), so read on. 
//Hash-based containers use hash codes to optimize searches. 
//Every object generates an integer value called a hash code. 
//Objects are stored in buckets based on the value of that hash code. 
//To search for an object, you request its key and search just that one bucket. 
//In .NET, every object has a hash code, determined by System.Object.GetHashCode().
//Any overload of GetHashCode() must follow these three rules:

//1.If two objects are equal(as defined by operator==), they must generate the 
//same hash value.Otherwise, hash codes can’t be used to find objects in containers.

//2. For any object A, A.GetHashCode() must be an instance invariant. 
//No matter what methods are called on A, A.GetHashCode() must always 
//return the same value.That ensures that an object placed in a bucket 
//is always in the right bucket.

//3. The hash function should generate a random distribution among all integers
//for all inputs. That’s how you get efficiency from a hash- based container.

void Main()
{
	//	SomeStruct s = new SomeStruct("Hello");
	//	s.GetHashCode().Dump();
	//	s.Message.GetHashCode().Dump();
	//	(s.GetHashCode() == s.Message.GetHashCode()).Dump();

	var k1 = new KeyValuePair<int, int>(10, 29);
	var k2 = new KeyValuePair<int, int>(10, 31);
	Console.WriteLine("k1 - {0}, k2 - {1}", k1.GetHashCode(), k2.GetHashCode());
	k1 = new KeyValuePair<int, int>(10, 29);
	k2 = new KeyValuePair<int, int>(10, 29);
	Console.WriteLine("k1 - {0}, k2 - {1}", k1.GetHashCode(), k2.GetHashCode());

	var v1 = new KeyValuePair<int, string>(10, "abc");
	var v2 = new KeyValuePair<int, string>(10, "def");
	Console.WriteLine("v1 - {0}, v2 - {1}", v1.GetHashCode(), v2.GetHashCode());

	var t1 = new KeyValuePair<string, int>("abc",786);
	var t2 = new KeyValuePair<string, int>("abc",970);
	Console.WriteLine("t1 - {0}, t2 - {1}", t1.GetHashCode(), t2.GetHashCode());
}


public struct SomeStruct
{
	//private readonly string msg;
	public int id;
	public int d;
	///private DateTime epoch;

	//public string Message { get { return msg; } }

	public SomeStruct(/*string msg*/int x, int d)
	{
		//this.msg = msg;
		id = x;
		this.d=d;
		//epoch = DateTime.Now;
	}

//	public override int GetHashCode()
//	{
//		return id ^ d;
//	}

	//	public override int GetHashCode()
//	{
//		return msg.GetHashCode();
//	}
}
//Производительность хеш-таблиц в значительной степени зависит от хеш-функции, 
//которая предъявляет определенные требования к методу GetHashCode:
//
//1. Если два объекта равны, их хеш - коды также должны быть равны.
//2. Если два объекта не равны, вероятность равенства их хеш-кодов должна быть минимальной.
//3. GetHashCode должен работать быстро (часто его производительность прямо пропорциональна размеру объекта).
//4. Хеш - код объекта не должен изменяться.
//https://professorweb.ru/my/csharp/optimization/level2/2_2.php
//https://habrahabr.ru/post/188038/
//inline DWORD GetNewHashCode()
//{
//	// Every thread has its own generator for hash codes so that we won't get into a situation
//	// where two threads consistently give out the same hash codes.        
//	// Choice of multiplier guarantees period of 2**32 - see Knuth Vol 2 p16 (3.2.1.2 Theorem A)
//	DWORD multiplier = m_ThreadId * 4 + 5;
//	m_dwHashCodeSeed = m_dwHashCodeSeed * multiplier + 1;
//	return m_dwHashCodeSeed;
//}