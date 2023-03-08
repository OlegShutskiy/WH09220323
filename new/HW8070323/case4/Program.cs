int arrayMaxValue = 100;
int arrayMinValue = 10;
int arraySize = 2;
int[,,] array = new int[arraySize, arraySize, arraySize];

int[] donorArray = new int[arraySize * arraySize * arraySize];
int temp;
for (int i = 0; i < donorArray.Length; i++) // donor array generation
{
    while (donorArray[i] == 0)
    {
        temp = new Random().Next(arrayMinValue, arrayMaxValue);
        if (Array.IndexOf(donorArray, temp, i) == -1)
        {
            donorArray[i] = temp;
        }
    }
}
// Console.WriteLine($"[{String.Join("; ", donorArray)}]");

int count = 0;
for (int arrayDepth1 = 0; arrayDepth1 < arraySize; arrayDepth1++)
{
    Console.Write(">");
    for (int arrayDepth2 = 0; arrayDepth2 < arraySize; arrayDepth2++)
    {
        Console.Write(">");
        for (int arrayDepth3 = 0; arrayDepth3 < arraySize; arrayDepth3++)
        {
            array[arrayDepth1, arrayDepth2, arrayDepth3] = donorArray[count];
            count++;
            Console.WriteLine($"\t{array[arrayDepth1, arrayDepth2, arrayDepth3]}\t({arrayDepth1},{arrayDepth2},{arrayDepth3})");
        }
    }
}
