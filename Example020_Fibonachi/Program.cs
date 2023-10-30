//Fibonachi
//f(n)=f(n-1)+f(n-2)

double Fibonachi(double n)
{
    if (n == 1 || n == 2)
    {
        return 1;
    }
    else
    {
        return Fibonachi(n - 1) + Fibonachi(n - 2);
    }
}

for (double i = 1; i < 50; i++)
{
    Console.WriteLine($"f{i} = {Fibonachi(i)}");
}
