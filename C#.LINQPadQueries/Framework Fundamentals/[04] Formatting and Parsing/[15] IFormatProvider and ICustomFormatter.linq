<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
</Query>

static void Main()
{
	double n = -123.45;
	
	IFormatProvider fp = new WordyFormatProvider();
	Console.WriteLine(string.Format("{0} in currency is {0:C}", n));
	Console.WriteLine(string.Format(new NumberFormatInfo(), "{0} in currency is {0:C}", n));
	Console.WriteLine(string.Format(new CultureInfo("en-GB"), "{0} in currency is {0:C}", n));
	Console.WriteLine(string.Format(fp, "{0} in currency is {0:C}", n));
	Console.WriteLine(string.Format(fp, "{0} in words is {0:W}", n));
	Console.WriteLine(string.Format(fp, "{0} in words is {0:w}", n));
	
	int x = 78;
	Console.WriteLine(string.Format("{0} in currency is {0:C}", x));
	Console.WriteLine(string.Format(fp, "{0} in currency is {0:C}", x));
	Console.WriteLine(string.Format(fp, "{0} in words is {0:d}", x));
	Console.WriteLine(string.Format(fp, "{0} in words is {0:w}", x));
}

public class WordyFormatProvider : IFormatProvider, ICustomFormatter
{
	private IFormatProvider parent;   // Allows consumers to chain format providers

	public WordyFormatProvider() : this(CultureInfo.CurrentCulture) { }

	public WordyFormatProvider(IFormatProvider parent) => this.parent = parent;

	public object GetFormat(Type formatType)
	{
		if (formatType == typeof(ICustomFormatter))
			return this;
		else
			return null;
	}

	public string Format(string format, object argument, IFormatProvider prov)
	{
		string[] numberWords = "zero one two three four five six seven eight nine minus point".Split();
			
		if (argument.GetType() != typeof(double))
		{
			try
			{
				return HandleOtherFormats(format, argument);
			}
			catch (FormatException e)
			{
				throw new FormatException($"The format of '{format}' is invalid.");
			}
		}
		
		if (string.IsNullOrWhiteSpace(format) || format.ToUpper(CultureInfo.InvariantCulture) != "W")
		{
			try
			{
				return HandleOtherFormats(format, argument);
			}
			catch (FormatException e)
			{
				throw new FormatException($"The format of '{format}' is invalid.");
			}
		}

		StringBuilder result = new StringBuilder();
		
		string digitList = string.Format(CultureInfo.InvariantCulture, "{0}", argument);
		
		foreach (char digit in digitList)
		{
			int i = "0123456789-.".IndexOf(digit);
			
			if (i == -1) 
			{
				continue;
			}
			if (result.Length > 0) 
			{
				result.Append(' ');
			}
			
			result.Append(numberWords[i]);
		}

		return result.ToString();
	}

	private string HandleOtherFormats(string format, object arg)
	{
		if (arg is IFormattable)
		{
			return ((IFormattable)arg).ToString(format, parent);
		}			
		else if (arg != null)
		{
			return arg.ToString();
		}		
		else
		{
			return String.Empty;
		}
			
	}
}