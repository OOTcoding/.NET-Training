<Query Kind="Statements" />

int i = 3;
int j = i++;
int k = ++i;
i.Dump();
j.Dump();
k.Dump();

//IL_0000:  ldc.i4.3    
//IL_0001:  stloc.0     // i
//IL_0002:  ldloc.0     // i
//IL_0003:  dup         
//IL_0004:  ldc.i4.1    
//IL_0005:  add         
//IL_0006:  stloc.0     // i
//IL_0007:  stloc.1     // j
//IL_0008:  ldloc.0     // i
//IL_0009:  ldc.i4.1    
//IL_000A:  add         
//IL_000B:  dup         
//IL_000C:  stloc.0     // i
//IL_000D:  ldloc.0     // i
//IL_000E:  call        LINQPad.Extensions.Dump<Int32>
//IL_0013:  pop         
//IL_0014:  ldloc.1     // j
//IL_0015:  call        LINQPad.Extensions.Dump<Int32>
//IL_001A:  pop         
//IL_001B:  call        LINQPad.Extensions.Dump<Int32>
//IL_0020:  pop
//IL_0021:  ret 