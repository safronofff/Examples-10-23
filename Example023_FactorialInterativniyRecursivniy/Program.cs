// Факториал числа Интеративным и рекурсивным методом

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result = result * i;
    }
    return result;
}

int FactorialRec(int n)
{
    if (n == 1)
    {
        return 1;
    }
    else if (n == 0)
    {
        return 1;
    }
    else
    {
        return n * FactorialRec(n - 1);
    }
}

Console.WriteLine(FactorialFor(10));
Console.WriteLine(FactorialRec(10));
