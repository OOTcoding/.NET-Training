<Query Kind="Program" />

void Main()
{
	
}
//Тип не должен быть запечатанным (sealed) классом. 
//Нельзя использовать этот подход для запечатанных классов или для значимых типов
// К тому же нельзя использовать этот подход для статических методов,
//потому что они не могут переопределяться.
//Существует проблема эффективности.
//Тип, определяемый только для переопределения метода, 
//понапрасну расходует некоторое количество системных ресурсов.
//И даже если вы не хотите переопределять поведение типа OnNameChanging, 
//код базового класса по-прежнему вызовет виртуальный метод,
//который помимо возврата управления ничего больше не делает.
//Метод ToUpper вызывается и тогда, когда OnNameChanging получает
//доступ к переданным аргументам, и тогда, когда не получает.

internal class Base
{
	private string m_name;

	protected virtual void OnNameChanging(string value)
	{
	}
	public string Name
	{
		get { return m_name; }
		set
		{
			OnNameChanging(value.ToUpper());
		}
	}
}

internal class Derived : Base
{
	protected override void OnNameChanging(string value)
	{
		if (string.IsNullOrEmpty(value))
			throw new ArgumentNullException("value");
	}
}