string[] array ={"spb", "moscow", "NY", "-2", "556"};
int newArraySize = 0;
string[] resultArray = new string[newArraySize];

int ArraySizeCount(string[] array, int newArraySize)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
            newArraySize++;
    }
    return newArraySize;
}

