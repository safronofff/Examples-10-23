// От меньшего к большему


string NumberFor1(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i}";
    }
    return result;
}

string NumberRec1(int a, int b)
{
    if (a <= b)
    {
        return $"{a}" + NumberRec1(a + 1, b);
    }
    else
    {
        return String.Empty;
    }
}

Console.WriteLine(NumberFor1(1, 10));
Console.WriteLine(NumberRec1(1, 10));

// От большего к меньшему

string NumberFor2(int a, int b)
{
    string result = String.Empty;
    for (int i = b; i >= a; i--)
    {
        result = result + $"{i}";
    }
    return result;
}

string NumberRec2(int a, int b)
{
    if (a <= b)
    {
        return NumberRec2(a + 1, b) + $"{a}";
    }
    else
    {
        return String.Empty;
    }
}

Console.WriteLine(NumberFor2(1, 10));
Console.WriteLine(NumberRec2(1, 10));
