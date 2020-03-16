<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

// A character set is an allocation of characters, 
// each with a numeric code or code point. 
// There are two character sets in common use: Unicode and ASCII. 

// A text encoding maps characters from their numeric code point
// to a binary representation.

// There are two categories of text encoding in .NET:
//  • Those that map Unicode characters to another character set (IBM’s EBCDIC, ASCII)
//  • Those that use standard Unicode encoding schemes (UTF-8, UTF-16, and UTF-32 (and the obsolete UTF-7)

// UTF-8 -default for stream I/O in .NET,
// it uses between 1 and 4 bytes to represent each character

// UTF-16 uses one or two 16-bit words to represent each character
// and is what .NET uses internally to represent characters and strings

// UTF-32 is the least space-efficient: it maps each code point directly
// to 32 bits, so every character consumes 4 bytes

// The easiest way to instantiate a correctly configured encoding class is to 
// call Encoding.GetEncoding with a standard IANA name:

Encoding utf8 = Encoding.GetEncoding ("utf-8");//Encoding.UTF8
Encoding chinese = Encoding.GetEncoding ("utf-16");//Encoding.Unicode

utf8.Dump();
chinese.Dump();

// The static GetEncodings method returns a list of all supported encodings:
foreach (EncodingInfo info in Encoding.GetEncodings())
	Console.WriteLine (info.Name);
	
	
System.IO.File.WriteAllText (@"C:\Users\MIB\Desktop\data.txt", "Testing...", Encoding.Unicode);
System.IO.File.WriteAllText (@"C:\Users\MIB\Desktop\data1.txt", "Testing...");//UTF-8 is the default text encoding for all file and stream I/O