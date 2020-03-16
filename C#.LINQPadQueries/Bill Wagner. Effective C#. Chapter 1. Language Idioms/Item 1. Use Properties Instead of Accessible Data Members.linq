<Query Kind="Program" />

void Main()
{
	Customer customer = new Customer();
	customer.Name = "Customer";
}
//легкость замены автосвойства обычным
//синхронизированный доступ, если понадобиться
//возможность виртуальности
//возможность наличия их в интерыфейсе
//разный доступ по чтению и записи

//1. Properties are far easier to change as you discover new requirements 
//or behaviors over time. You might soon decide that your customer type
//should never have a blank name. If you used a public property for Name,
//that’s easy to fix in one location:
public class Customer
{
	private string name;
	public string Name
	{
		get { return name; }
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException("Name cannot be blank. ", nameof(Name));
			}
				
			name = value;
		}
		// More Elided
	}
}

//2. Because properties are implemented with methods, adding multithreaded
//support is easier. You can enhance the implementation of the get and set
//accessors to provide synchronized access to the data:
public class Customer1
{
	private object syncHandle = new object();
	private string name;
	public string Name
	{
		get
		{
			lock (syncHandle)
				return name;
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException("Name cannot be blank. ", nameof(Name));
			}

			lock (syncHandle)
				name = value;
		}
		// More Elided
	}
}

//3. Properties have all the language features of methods. Properties can be virtual:
public class Customer2
{
	public virtual string Name
	{
		get;
		set;
	}
}

//4. You can extend properties to be abstract and define properties as part of an 
//interface definition, using similar syntax to implicit properties.
//The example below shows a property definition in a generic interface. 
public interface INameValuePair<T>
{
	string Name
	{
		get;
	}
	T Value
	{
		get;
		set;
	}
}
//5. The accessors for a property are two separate methods that get compiled 
//into your type. You can specify different accessibility modifiers to the get
//and set accessors in a property in C#. This gives you even greater control
//over the visibility of those data elements you expose as properties:
public class Customer3
{
	public virtual string Name
	{
		get;
		protected set;
	}
	// remaining implementation omitted
}