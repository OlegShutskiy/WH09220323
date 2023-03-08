int arrayRows = 5;
int arrayColumns = 4;
int arrayMaxValue = 10;
int arrayMinValue = 1;

Console.WriteLine("Исходный массив:");
int[,] array = new int[arrayRows, arrayColumns];

int currentMinStringValue = Int32.MaxValue;
int currentIndexMinString = -1;

for (int i = 0; i < arrayRows; i++)
{
    int sumStringElement = 0;
    for (int j = 0; j < arrayColumns; j++)
    {
        array[i, j] = new Random().Next(arrayMinValue, arrayMaxValue);
        Console.Write(array[i, j] + "\t|");
        sumStringElement += array[i, j];
    }
    Console.WriteLine("<-- row " + (i + 1) + " sum = " + sumStringElement);
    if (sumStringElement < currentMinStringValue)
    {
        currentMinStringValue = sumStringElement;
        currentIndexMinString = i;
    }
}
Console.WriteLine("Строка с наименьшей суммой элементов: \nrow " + (currentIndexMinString + 1) + " sum = " + currentMinStringValue);

