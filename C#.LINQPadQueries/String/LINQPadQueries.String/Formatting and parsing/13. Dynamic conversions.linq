<Query Kind="Statements" />

//public static object ChangeType (object value, Type conversionType);

Type targetType = typeof (int);
object source = "42";
object result = Convert.ChangeType (source, targetType);
result.Dump();             // 42
result.GetType().Dump();

int x = 90;
object obj = x;
double y = (double)Convert.ChangeType(obj, typeof (double));
y.Dump();