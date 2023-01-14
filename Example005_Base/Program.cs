int a = 4;
int b = 1;
int c = 9;
int d = 6;
int e = 2;

int max = a;
if(max < b) max = b;
if(max < c) max = c;
if(max < d) max = d;
if(max < e) max = e;

Console.Write("max = ");
Console.WriteLine(max);