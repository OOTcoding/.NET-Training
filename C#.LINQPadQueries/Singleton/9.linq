<Query Kind="Program">
  <Namespace>System.Data.Entity</Namespace>
</Query>

void Main()
{
	Process.Start(@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", Assembly.GetExecutingAssembly().Location);
}

//Реализация синглтонов в .NET: Field-like vs. Lazy
public class FieldLikeSingleton
{
	public static FieldLikeSingleton Instance { get; }
		= new FieldLikeSingleton();
	
	// тело конструктора синглтона вызывается в статическом конструкторе

	private FieldLikeSingleton() { }
}

public class FieldLikeLazySingleton
{
	private static readonly Lazy<FieldLikeLazySingleton> instance =
		new Lazy<FieldLikeLazySingleton>(() => new FieldLikeLazySingleton());

	// в статическом конструкторе вызывается лишь 
	// конструктор объекта Lazy<T>,
	// а сам объект создается при первом обращении.

	public static FieldLikeLazySingleton Instance => instance.Value;

	private FieldLikeLazySingleton() { }
}

/// <summary>Thread-safe singleton.</summary>
public class Singleton<T> where T : class
{
	/// <summary>The one and only instance of the Singleton class.</summary>
	private static readonly Lazy<T> _instance = new Lazy<T>(
		() => (T)typeof(T).GetConstructor(
			BindingFlags.Instance | BindingFlags.NonPublic,
			null, new Type[0], null).Invoke(null));

	/// <summary>Gets the singleton instance.</summary>
	public static T Instance { get { return Singleton<T>._instance.Value; } }
}