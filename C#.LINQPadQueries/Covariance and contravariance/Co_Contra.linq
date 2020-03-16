<Query Kind="Program" />

void Main()
{
	CustomComparison<string> comp = new CustomComparison<string>(CompareString);
	comp("22", "11").Dump();
	CustomComparison<object> comp1 = new CustomComparison<object>(CompareObject);
	comp = comp1;
}

public delegate int CustomComparison<in T>(T x, T y);
// public delegate int CustomComparison<T>(T x, T y);

public int CompareObject(object lhs, object rhs)
	=> lhs.GetHashCode() - rhs.GetHashCode();
	
public int CompareString(string lhs, string rhs) 
	=> lhs.GetHashCode() - rhs.GetHashCode();

// В версии С# 4 предлагаются обобщенные ковариантность и контравариантность
// для делегатов и интерфейсов. Это полностью отличается от вариантности, 
// показанной до сих пор - в данный момент мы имеем дело с созданием новых
// экземпляров делегатов. Обобщенная вариантность в С# 4 использует ссылочные 
// преобразования, которые не создают новые объекты - они просто представляют
// существующий объект как относящийся к другому типу.

