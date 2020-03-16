<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
</Query>

void Main()
{
	int x;
	int y = 1;
	OutParametrs(out x);
	RefParametrs(ref y);
	InParametrs(x);
	ValParametrs(y);
}

void OutParametrs(out int x)
{
	x = 10;
}

void RefParametrs(ref int x)
{
	x = 10;
}

int InParametrs(in int x)
{
	//x = 10;//CTE
	int y = x;
	return y;
}

void ValParametrs(int x)
{
	x = 11;
}