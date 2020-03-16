<Query Kind="Statements" />

Tuple<string, int> tupleBefore = new Tuple<string, int>("three", 3);
tupleBefore.Item1.Dump();

// We can create tuples easily in C# 7:
var tuple = ("three", 3);
tuple.Dump();

// With explicit typing:

(string, int) tuple2 = tuple;
tuple2.Item1.Dump();

// We can even name the fields!

var namedTuple = (word:"three", number:3);

// Named tuples are compiled the same underneath (Item1, Item2):

// But with compiler trickery, we can refer to the names in source code:

namedTuple.number.Dump();
namedTuple.word.Dump();

// Tuples rely on a new type called System.ValueTuple, 
// in the NuGet package of the same name.
// LINQPad includes this automatically, so you don't have
// to import anything.