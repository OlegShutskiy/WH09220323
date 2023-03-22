int m, n;
Console.Write("Введите начальное значение M: ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение N: ");
n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    //Console.WriteLine("M = " + m + "; N = " + n);
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return n + 1;
}

Console.WriteLine(Akkerman(m, n));