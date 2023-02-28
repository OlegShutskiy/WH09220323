Console.Write("Введите любое число (a): ");
int a = Convert.ToInt32(Console.ReadLine());

int[] array = new int[a];

for (int i = 0; i < a; i++)
{
    array[i] = new Random().Next(a + 1);
    Console.Write(array[i] + "; ");
}