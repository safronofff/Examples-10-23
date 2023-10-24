int a1=23;
int b1=12;
int c1=57;
int a2=41;
int b2=72;
int c2=38;
int a3=25;
int b3=61;
int c3=89;

/*int max=a1;
if (b1>max)max=b1;
if (c1>max)max=c1;

if (a2>max)max=a2;
if (b2>max)max=b2;
if (c2>max)max=c2;

if (a3>max)max=a3;
if (b3>max)max=b3;
if (c3>max)max=c3;

Console.WriteLine(max);*/

int Max (int x1, int x2, int x3)
{
    int result = x1;
    if (x2>result)result=x2;
    if (x3>result)result=x3;
    return result;
}

/*int max1 = Max(a1,b1,c1);
int max2 = Max(a2,b2,c2);
int max3 = Max(a3,b3,c3);
int max = Max(max1,max2,max3);
Console.WriteLine($"max1={max1},max2={max2},max3={max3},max={max}");*/

int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));

Console.WriteLine(max);


