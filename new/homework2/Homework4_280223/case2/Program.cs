Console.Write("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (a != 0)
{
    result += a % 10;
    a /= 10;
}

Console.WriteLine($"Сумма цифр в числе = {result}");