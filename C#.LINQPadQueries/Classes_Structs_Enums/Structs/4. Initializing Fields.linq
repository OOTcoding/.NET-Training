<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	var o = new Basis();
	o.Dump();
	var v = new Vector();
	v.Dump();
	//Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",Assembly.GetExecutingAssembly().Location);
}

class Basis 
{
	public Vector direction1;
	public Vector direction2; 
}

class Vector 
{
	public Point start;
	public Point end; 
}

struct Point 
{
	public int x;
	public int y; 
}