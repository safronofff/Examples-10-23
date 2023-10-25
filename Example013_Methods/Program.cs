// Вид 1 - не принимает и не возвращает аргументов

void Method1()
{
    Console.WriteLine("Hello, World!");
}

//Method1();  // Вызов метода

// Вид 2 - принимает аргументы, но не возвращает аргументы

void Method2(string text)
{
    Console.WriteLine(text);
}

//Method2("Hello World!"); // Вызов метода
//Method2(text: "Hello World!"); // Вызов метода с указанием аргумента (удобно, когда из много)

void Method21(string text, int count)
{
    int i=0;
    while (i<count)
    {
        Console.WriteLine(text);
        i++;
    }
    
}

//Method21("Hello World!!!",5);
//Method21(text:"Hello World!!!",count:5);
//Method21(count:5,text:"Hello World!!!");

// Вид 3 - не принимает аргументы, возвращает аргументы

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

// Вид 4 - принимает аргументы, возвращает аргументы

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i<count)
    {
        result=result+text;
        i++;
    }
    return result;
}

string res = Method4(count:10, text: "Hello.User ");
//Console.WriteLine(res);

string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result=result+text;
    }
    return result;
}

//string res = Method41(count:10, text: "Hello.User ");
//Console.WriteLine(res);