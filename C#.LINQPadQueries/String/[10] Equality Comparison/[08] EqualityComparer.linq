<Query Kind="Program" />

static void Main() { }

// A more efficient version of the previous method, when you're dealing with generics:
class Test <T>
{
	T value;
	public void SetValue (T newValue)
	{
		if (!EqualityComparer<T>.Default.Equals (newValue, value))
		{
			value = newValue;
			OnValueChanged();
		}
	}

	protected virtual void OnValueChanged() { /*...*/ }
}