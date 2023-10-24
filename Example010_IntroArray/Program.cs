//индекс массива 0,1, 2, 3, 4, 5, 6, 7, 8
int [] array = {10,24,13,74,56,16,57,82,97};

array[0] = 12;
Console.WriteLine(array);

int Max (int x1, int x2, int x3)
{
    int result = x1;
    if (x2>result)result=x2;
    if (x3>result)result=x3;
    return result;
}

int max = Max(Max(array[0],array[1],array[2]),
              Max(array[3],array[4],array[5]),
              Max(array[6],array[7],array[8]));

Console.WriteLine($"max={max}");

