// Вычислить А в степени N

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result = result * a;
    }
    return result;
}

int PowerRec(int a, int n)
{
    //return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    if (n == 0)
    {
        return 1;
    }
    /*else if (n == 1) //вызывает ошибку и считает на одну рекурсию меньше
    {
        return 1;
    }*/
    else
    {
        return PowerRec(a, n - 1) * a;
    }
}

Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));
