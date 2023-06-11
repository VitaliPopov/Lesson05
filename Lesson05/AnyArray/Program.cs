int[] array = { 11, 24, 31, 41, 51, 24, 34, 27, 18 };

int n = array.Length;
int find = 24;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
    }
