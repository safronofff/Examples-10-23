int[] array = {13,45,76,33,61,12,60,33,20,15,33};

int n = array.Length;
int find = 33;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}