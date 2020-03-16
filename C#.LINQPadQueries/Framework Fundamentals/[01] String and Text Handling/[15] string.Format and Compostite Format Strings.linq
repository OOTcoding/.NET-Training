<Query Kind="Statements" />

// When calling String.Format, provide a composite format string followed by each of the embedded variables
string composite = "It's {0} degrees in {1} on this {2} morning";
string s = string.Format (composite, 35, "Perth", DateTime.Now.DayOfWeek);
s.Dump();
string s1 = $"It's {35} degrees in {"Perth"} on this {DateTime.Now.DayOfWeek} morning";
s1.Dump();

// The minimum width in a format string is useful for aligning columns.
// If the value is negative, the data is left-aligned; otherwise, it’s right-aligned:
composite = "Name={0,-20} Credit Limit={1,15:C}";

Console.WriteLine (string.Format (composite, "Mary", 500));
Console.WriteLine (string.Format (composite, "Elizabeth", 20000));

// The equivalent without using string.Format:
s = "Name=" + "Mary".PadRight (20) + " Credit Limit=" + 500.ToString ("C").PadLeft (15);
s.Dump();