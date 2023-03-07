
int m = 3;
int n = 4;
int arrayMaxValue = 10;
int arrayMinValue = 1;
int[,] array = ArrayGenerator(m, n, arrayMaxValue, arrayMinValue);

Console.Write("Введите искомое число --> ");
int findNumber = Convert.ToInt32(Console.ReadLine());
bool numberFound = false;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (array[i, j] == findNumber)
        {
            Console.WriteLine($"Число найдено: Строка {i + 1} ; Колонка {j + 1}");
            numberFound = true;
        }
    }
}

if (numberFound != true) Console.WriteLine("Число НЕ найдено");


int[,] ArrayGenerator(int lenghtRows, int lenghtColum, int maxValue, int minValue)
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