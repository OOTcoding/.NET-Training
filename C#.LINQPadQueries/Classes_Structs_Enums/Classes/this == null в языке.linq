<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Reflection.Emit.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
  <Namespace>System.Reflection.Emit</Namespace>
</Query>

void Main()
{
	SomeClass someClass = null;
	someClass.Foo();
	//CallingNullReferenceThroughReflectionEmit();
	var method = typeof(SomeClass).GetMethod("Foo");
	var action = (Action)Delegate.CreateDelegate(typeof(Action), null, method);
	action();
}

static void CallingNullReferenceThroughReflectionEmit()
{
    // Создаем статический метод Test "динамически"
    DynamicMethod dm = new DynamicMethod("Test", typeof(void), new Type[] { typeof(SomeClass) }, true);
            
    // Получаем ILGenerator для этого метода
    var il = dm.GetILGenerator();
 
    // Загружаем аргумент (в данном случае, это объект типа SomeClass)
    il.Emit(OpCodes.Ldarg_0);
            
    // Добавляем инструкцию невиртуального вызова метода Foo
    MethodInfo method = typeof(SomeClass).GetMethod("Foo");
    il.Emit(OpCodes.Call, method);
            
    // Инструкция выхода из метода
    il.Emit(OpCodes.Ret);
    SomeClass someClass = null;
    // Вызываем делегат и передаем null в качестве параметра
    dm.Invoke(null, new object[] { someClass });
}

public class SomeClass
{
    public void Foo()
    {
        // Проверка this на null?!
        if (this == null)
        {
            Console.WriteLine("Ух ты! this == null!");
        }
    }
}