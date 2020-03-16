<Query Kind="Program" />

void Main()
{

}

//partial struct A
sealed partial class A
{
	private string name;

	//static 
	partial void OnNameChanging(string value);

	public string Name
	{
		get { return name; }
		set
		{
			OnNameChanging(value.ToUpper());
		}
	}
}
//partial struct A
sealed partial class A
{
	//static 
	partial void OnNameChanging(string value)
	{
		if (string.IsNullOrEmpty(value))
			throw new ArgumentNullException(nameof(value));
		value = value.ToUpper();
		//TODO 
	}
}