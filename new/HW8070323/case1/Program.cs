int arrayRows = 3;
int arrayColumns = 4;
int arrayMaxValue = 10;
int arrayMinValue = 1;

Console.WriteLine("Исходный массив:");
int[,] array = ArrayGenerator(arrayRows, arrayColumns, arrayMaxValue, arrayMinValue);

for (int currentStringIndex = 0; currentStringIndex < arrayRows; currentStringIndex++)
{
    SortStrOfArray(array, currentStringIndex);
}

Console.WriteLine("\nРезультат: ");
for (int i = 0; i < arrayRows; i++)
{

    for (int j = 0; j < arrayColumns; j++)
    {
        Console.Write(array[i, j] + "\t|");
    }
    Console.WriteLine("<-- row " + (i + 1));
}


void SortStrOfArray(int[,] array, int currentStringIndex)
{
    int tempMemory;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = array.GetLength(1) - 1; j > i; j--)
        {
            if (array[currentStringIndex, j] < array[currentStringIndex, j - 1])
            {
                tempMemory = array[currentStringIndex, j];
                array[currentStringIndex, j] = array[currentStringIndex, j - 1];
                array[currentStringIndex, j - 1] = tempMemory;
            }
        }
    }
}



int[,] ArrayGenerator(int lenghtRows, int lenghtColum, int maxValue, int minValue) // рандом генератор
{
    int[,] array = new int[lenghtRows, lenghtColum];
    for (int i = 0; i < lenghtRows; i++)
    {
        for (int j = 0; j < lenghtColum; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
            Console.Write(array[i, j] + "\t|");
        }
        Console.WriteLine("<-- row " + (i + 1));
    }
    return array;
}