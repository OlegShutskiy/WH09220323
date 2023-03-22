int m, n;
Console.Write("Введите начальное значение M: ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение N: ");
n = Convert.ToInt32(Console.ReadLine());

int SumRange(int start, int end)
{
    int sum = 0;
    if (start < end) sum = start + end + SumRange(start + 1, end - 1);
    else if (start == end) sum = end;
    return sum;
}
Console.WriteLine(SumRange(m, n));