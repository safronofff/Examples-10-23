﻿int[] array = new int[10];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index<length)
    {
        collection[index]=new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count=collection.Length;
    int index=0;
    int position=-1; // что бы при отсутствии эл-та не выводился индекс 0 позиции
    while(index<count)
    {
        if(collection[index]==find)
        {
            position=index;
            break;
        }
        index++;
    }
    return position;
}

FillArray(array);
array[4]=4;
array[6]=4;

PrintArray(array);

Console.WriteLine();

int pos=IndexOf(array,4);
Console.WriteLine(pos);
