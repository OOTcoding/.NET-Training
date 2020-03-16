<Query Kind="Program" />

void Main()
{
	
}
//Теперь класс запечатан (хотя это и не обязательно).
//В действительности, класс мог бы быть статическим классом или даже значимым типом.
//В этом коде есть несколько мест, на которые необходимо обратить внимание.
//Код, сгенерированный программой, и код, написанный программистом,
//на самом деле являются двумя частичными определениями, 
//которые в конце концов образуют одно определение типа.
//Код, сгенерированный программой, представляет собой объявление
//частичного метода.Этот метод помечен ключевым словом partial и не имеет тела.
//Код, написанный программистом, реализует объявление частичного метода.
//Этот метод также помечен ключевым словом partial и тоже не имеет тела.

internal sealed partial class Base
{
	private string m_name;

	partial void OnNameChanging(string value);
	public string Name
	{
		get { return m_name; }
		set
		{
			OnNameChanging(value.ToUpper());
		}
	}
}

internal sealed partial class Base
{
	partial void OnNameChanging(string value)
	{
		if (String.IsNullOrEmpty(value))
			throw new ArgumentNullException(nameof(value));
	}
}