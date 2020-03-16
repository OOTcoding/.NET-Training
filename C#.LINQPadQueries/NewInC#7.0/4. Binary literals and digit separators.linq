<Query Kind="Statements" />

// You can use underscores within numeric literals to make them more readable:

int x = 12_000;
x.Dump();

// The '0b' prefix now denotes a binary literal:

var b = 0b1010_1011_1100_1101_1110_1111;
b.Dump();



byte b1 = 0x7B;
b1.Dump();
short s = 0xF15;
s.Dump();
uint i = 0x989680;
i.Dump();
double mole = 6.02214179e23; 
mole.Dump();
double planck = 6.62606896e-34;

decimal x1 = 0.12345678901234567890123456789M;
double x2 = 0.12345678901234567890123456789;
x1.Dump();
x2.Dump();
decimal price = 79.95M;
price.Dump();
