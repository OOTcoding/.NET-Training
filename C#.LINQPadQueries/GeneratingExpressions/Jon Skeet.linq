<Query Kind="Statements">
  <Namespace>System.Data.Entity</Namespace>
</Query>

string[] words = { "zero", "one", "two", "three", "four" };
int[] numbers = { 0, 1, 2, 3, 4 };

//Examples of aggregation operators
numbers.Sum().Dump();
numbers.Count().Dump();
numbers.Average().Dump(); ;
words.Min(word => word.Length).Dump(); ;
words.Max(word => word.Length).Dump(); ;
numbers.Aggregate("seed",
	(current, item) => current + item, result => result.ToUpper()).Dump();

//Concat example
numbers.Concat(new[] { 2, 3, 4, 5, 6 }).Dump();

//Conversion examples
object[] allStrings = { "These", "are", "all", "strings" };
object[] notAllStrings = { "Number", "at", "the", "end", 5 };

allStrings.Cast<string>().Dump();
allStrings.OfType<string>().Dump();
//notAllStrings.Cast<string>().Dump();
notAllStrings.OfType<string>().Dump();
numbers.ToArray().Dump();
numbers.ToList().Dump();
words.ToDictionary(w => w.Substring(0, 2)).Dump();
// Key is first character of word
words.ToLookup(word => word[0]).Dump();
//words.ToDictionary(word => word[0]).Dump();

//Single element selection examples
words.ElementAt(2).Dump();
words.ElementAtOrDefault(10).Dump();
words.First().Dump();
words.First(w => w.Length == 3).Dump();
// words.First(w => w.Length == 10).Dump();
words.FirstOrDefault(w => w.Length == 10).Dump();
words.Last().Dump();
//words.Single().Dump();
//words.SingleOrDefault().Dump();
words.Single(word => word.Length == 5).Dump();
//words.Single(word => word.Length == 10).Dump();
words.SingleOrDefault(w => w.Length == 10).Dump();

//Sequence equality examples
words.SequenceEqual(new[] { "zero", "one", "two", "three", "four" }).Dump();
words.SequenceEqual(new[] { "zero", "one", "two", "three", "four" }).Dump();
words.SequenceEqual(new[] { "ZERO", "ONE", "TWO", "THREE", "FOUR" }, StringComparer.OrdinalIgnoreCase).Dump();

//Generation examples
numbers.DefaultIfEmpty().Dump();
new int[0].DefaultIfEmpty().Dump();
new int[0].DefaultIfEmpty(10).Dump();
Enumerable.Range(15, 2).Dump();
Enumerable.Repeat(25, 2).Dump();
Enumerable.Empty<int>().Dump();

//GroupBy examples
words.GroupBy(word => word.Length).Dump();
words.GroupBy(word => word.Length,   // Key
			word => word.ToUpper() // Group element
   ).Dump();
// Project each (key, group) pair to string
words.GroupBy
   (word => word.Length,
	(key, g) => key + ": " + g.Count()).Dump();

//Join examples
string[] names = { "Robin", "Ruth", "Bob", "Bob" };
string[] colors = { "Red", "Red", "Blue", "Beige" };

names.Join // Left sequence
  (colors, // Right sequence
 name => name[0], // Left key selector
 color => color[0], // Right key selector
					// Projection for result pairs
 (name, color) => name + " - " + color
).Dump();

names.GroupJoin
		   (colors,
			name => name[0],
			color => color[0],
			// Projection for key/sequence pairs
			(name, matches) => name + ": " +
			   string.Join("/", matches.ToArray())
		   ).Dump();

//Partitioning examples
words.Take(2).Dump();
words.Skip(2).Dump();
words.TakeWhile(word => word.Length <= 4).Dump();
words.SkipWhile(word => word.Length <= 4).Dump();

//Projection examples
words.Select(word => word.Length).Dump();
words.Select((word, index) => index.ToString() + ": " + word).Dump();
words.SelectMany(word => word.ToCharArray()).Dump();
words.SelectMany((word, index) => Enumerable.Repeat(word, index)).Dump();

//Zip examples
names.Zip(colors, (x, y) => x + "-" + y).Dump();
// Second sequence stops early
names.Zip(colors.Take(3), (x, y) => x + "-" + y).Dump();

//Quantifier examples
words.All(word => word.Length > 3).Dump();
words.All(word => word.Length > 2).Dump();
words.Any().Dump();
words.Any(word => word.Length == 6).Dump();
words.Any(word => word.Length == 5).Dump();
words.Contains("FOUR").Dump();
words.Contains("FOUR", StringComparer.OrdinalIgnoreCase).Dump();

//Filtering
words.Where(word => word.Length > 3).Dump();
words.Where((word, index) => index < word.Length).Dump();

//Set-based operators
string[] abbc = { "a", "b", "b", "c" };
string[] cd = { "c", "d" };
abbc.Distinct().Dump();
abbc.Intersect(cd).Dump();
abbc.Union(cd).Dump();
abbc.Except(cd).Dump();
cd.Except(abbc).Dump();

//Sorting
words.OrderBy(word => word).Dump();// Order words by second character
words.OrderBy(word => word[1]).Dump();
// Order words by length;
// equal lengths returned in original
// order
words.OrderBy(word => word.Length).Dump();
words.OrderByDescending(word => word.Length).Dump();
// Order words by length and then
// alphabetically
words.OrderBy(word => word.Length)
	  .ThenBy(word => word).Dump();
// Order words by length and then
// alphabetically backwards
words.OrderBy(word => word.Length)
	  .ThenByDescending(word => word).Dump();
words.Reverse().Dump();