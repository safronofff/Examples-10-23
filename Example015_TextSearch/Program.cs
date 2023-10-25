/*     ==Работа с текстом==
Дан текст.
В тексте нужно:
1-Все пробелы земенить черточкам
2-Маленькие буквы "К" заменить большими
3-Большие "С" заменить большими*/

string text="Жили-были старик со старухой. Вот и просит старик"
            +"Испеки мне, старая, колобок."
            +"Да из чего испечь-то? Муки нет."
            +"Эх, старуха! По амбару помети, по сусекам поскреби - вот и найдется."
            +"Старуха так и сделала: намела, наскребла горсти две муки,"
            +"замесила тесто на сметане, скатала в колобок, изжарила в "
            +"масле и положила на окно простыть.";

/* string s = "qwerty"
               012345
s[3] = r*/

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i]==oldValue) 
        {
            result=result + $"{newValue}";
        }
        else
        {
            result=result + $"{text[i]}";
        }
    }

    return result;
}

string newText=Replace(text,' ','|');
Console.WriteLine(newText);
Console.WriteLine();
newText=Replace(newText,'к','К');
Console.WriteLine(newText);
Console.WriteLine();
newText=Replace(newText,'с','С');
Console.WriteLine(newText);