string[] array ={"spb", "moscow", "NY", "-2", "556"};
int newArraySize = 0;

newArraySize = ArraySizeCount(array, newArraySize);
string[] resultArray = new string[newArraySize];

RecordNewArray(array, resultArray);
PrintArray(resultArray);

int ArraySizeCount(string[] array, int newArraySize)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) newArraySize++;
    }
    return newArraySize;
}

void RecordNewArray(string[] array, string[] newArray)
{
    int k = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i].Length <= 3)
        {
            newArray[k] = array[i];
            k++;
        }     
    }
}

void PrintArray(string[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
