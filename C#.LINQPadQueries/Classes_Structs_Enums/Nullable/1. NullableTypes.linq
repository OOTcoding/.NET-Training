<Query Kind="Program" />

void Main()
{
    Nullable<int> x = 5;
    x = new Nullable<int>(5);
    Console.WriteLine("Instance with value:");
    Display(x);
    Console.WriteLine();
    x = new Nullable<int>();
    Console.WriteLine("Instance without value:");
    Display(x);    
}

static void Display(Nullable<int> x)
{
    Console.WriteLine($"HasValue: {x.HasValue}");
	
    if (x.HasValue)
    {
        Console.WriteLine($"Value: {x.Value}");
        Console.WriteLine($"Explicit conversion: {(int)x}");
    }
	
    Console.WriteLine($"GetValueOrDefault(): {x.GetValueOrDefault()}");
    Console.WriteLine($"GetValueOrDefault(10): {x.GetValueOrDefault(10)}");
    Console.WriteLine($"ToString(): {x.ToString()}");
    Console.WriteLine($"GetHashCode(): {x.GetHashCode()}");
}