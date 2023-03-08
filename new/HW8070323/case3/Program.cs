int arrayRows = 4;
int arrayColumns = 4;
int arrayMaxValue = 10;
int arrayMinValue = 1;

Console.WriteLine("Исходный массив :");
int[,] matrixA = ArrayGenerator(arrayRows, arrayColumns, arrayMaxValue, arrayMinValue);

Console.WriteLine("\nИсходный массив B:");
int[,] matrixB = ArrayGenerator(arrayRows, arrayColumns, arrayMaxValue, arrayMinValue);

int[,] resultArray = new int[arrayRows, arrayColumns];

Console.WriteLine("\nРезультат:");
for (int i = 0; i < arrayRows; i++)
{
    for (int j = 0; j < arrayColumns; j++)
    {
        resultArray[i, j] = matrixA[i, j] * matrixB[i, j];
        Console.Write(resultArray[i, j] + "\t|");
    }
    Console.WriteLine("<-- row " + (i + 1));
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