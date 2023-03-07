
int m = 3;
int n = 4;
int arrayMaxValue = 100;
int arrayMinValue = 1;
double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().NextDouble();
        array[i, j] = array[i, j] * (arrayMaxValue - arrayMinValue) + arrayMinValue;
        array[i, j] = Math.Round(array[i, j], 2);
        Console.Write(array[i, j] + "\t|");
    }
    Console.WriteLine("<-- row " + (i + 1));
}