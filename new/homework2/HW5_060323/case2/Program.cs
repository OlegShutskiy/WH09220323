Console.Write("Введите количество элементов массива ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void mas(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().Next(-99, 99);
        Console.Write(randomArray[i] + " ");
    }

}

int kol(int[] randomArray)
{
    int sum = 0;
    int i = 1;
    while (i < randomArray.Length)
    {
        sum = sum + randomArray[i];
        i = i + 2;
    }
    return sum;
}

mas(a);
Console.Write($"\nCумма элементов, стоящих на нечётных позициях: {kol(randomArray)}");