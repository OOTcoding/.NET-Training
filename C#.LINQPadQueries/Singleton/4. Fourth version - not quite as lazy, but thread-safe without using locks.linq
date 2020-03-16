<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
</Query>

#region Fourth version
// Fourth version - not quite as lazy, 
// but thread-safe without using locks
#endregion
// Почти «ленивая» реализация
public sealed class Singleton
{
	private static readonly Singleton instance = new Singleton();

	// Добавление явного статического конструктора 
	// приказывает компилятору 
	// не помечать тип атрибутом beforefieldinit
	static Singleton() { }

	private Singleton(){ }

	public static Singleton Instance
	{
		get => instance;
	}
}

public sealed class SingletonAlternative
{
	private static readonly SingletonAlternative instance;

	// Добавление явного статического конструктора 
	// приказывает компилятору 
	// не помечать тип атрибутом beforefieldinit
	static SingletonAlternative() => instance = new SingletonAlternative();
	
	private SingletonAlternative() { }

	public static SingletonAlternative Instance
	{
		get => instance;
	}
}

// C# 6.0
public class FieldLikeSingleton
{
	public static FieldLikeSingleton Instance { get; }
		= new FieldLikeSingleton();

	static FieldLikeSingleton() { }
	// тело конструктора синглтона вызывается в статическом конструкторе

	private FieldLikeSingleton() { }
}


void Main()
{
	// Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", Assembly.GetExecutingAssembly().Location);
}