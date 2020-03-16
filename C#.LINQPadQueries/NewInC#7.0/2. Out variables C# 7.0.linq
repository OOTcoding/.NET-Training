<Query Kind="Statements" />

// When calling methods with out parameters, you can declare variables inline:

if (int.TryParse ("123", out int result))   // result has been declared inline
	result.Dump();

// Note that the newly introduced variable is still in scope:

result.Dump();

// Out parameters can be implicitly typed (var):

int.TryParse ("234", out var result2);
result2.Dump();
