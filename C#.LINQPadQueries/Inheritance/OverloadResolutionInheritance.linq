<Query Kind="Program">
  <Namespace>System.Data.Entity</Namespace>
</Query>


//Разрешение перегрузки представляет собой механизм времени связывания для выбора
//наилучшего функционального элемента из набора возможных функциональных элементов 
//для вызова при заданном списке аргументов.

//Разрешение перегрузки выбирает функциональный элемент, который будет вызван,
//в следующих контекстах языка C#:
//• Вызов метода, заданного в выражении-вызова
//• Вызов конструктора экземпляра, заданного в выражении создания объекта
//• Вызов кода доступа к экземпляру через доступ к элементу
//• Вызов предопределенной или определенной пользователем операции через выражение

//Каждый из этих контекстов определяет набор возможных функциональных элементов 
//и список аргументов своим собственным уникальным способом.
//Например, набор кандидатов для вызова метода не включает методы, помеченные как override, 
//и методы родительского класса не являются кандидатами, если какой-либо метод производного 
//класса является подходящим.
//После того как возможные функциональные элементы и список аргументов определены, 
//выбор лучшего функционального элемента происходит одинаково во всех случаях:
//• Для заданного набора подходящих возможных функциональных элементов определяется 
//лучший функциональный элемент.Если набор содержит только один функциональный элемент,
//он и есть лучший.
//В противном случае лучшим функциональным элементом является тот, который лучше остальных 
//соответствует данному списку аргументов, что выполняется путем сравнения каждого
//функционального элемента со всеми другими функциональными элементами. 
//
//Если не находится в точности один лучший функциональный элемент, 
//вызов функционального элемента является неоднозначным и выдается ошибка времени связывания.

//подходящий функциональный элемент (applicable function member)
//лучший функциональный элемент(better function member).

void Main()
{
	Derived d = new Derived();
	d.Foo("test");
	
	d.Foo(12.ToString());
}

//class Base
//{
//	public virtual void Foo(string x) => "Virtual base class method".Dump();
//	public void Foo(object x) => "Not virtual base class method with string".Dump();
//}
//
//class Derived : Base
//{
//	public override void Foo(string x) => "Override virtual base class method".Dump();
//	public void Foo(int x) => "Not virtual derived class method with int parametr".Dump();
//	public void Foo(float x) => "Not virtual derived class method with float parameter".Dump();
//}

class Base
{
	public virtual void Foo(object x) => "Virtual base class method".Dump();
	public void Foo(string x) => "Not virtual base class method with string".Dump();
}

class Derived : Base
{
	public override void Foo(object x) => "Override virtual base class method".Dump();
	//public void Foo(int x) => "Not virtual derived class method with int parametr".Dump();
	//public void Foo(float x) => "Not virtual derived class method with float parameter".Dump();
}







