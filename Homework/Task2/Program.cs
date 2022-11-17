// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0


int[] CreateArray(int length, int min, int max)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max);
    }
    return tempArray;
}

void PrintArray(int[] intArray)
{
    Console.Write($"{intArray[0]}");
    for (int i = 0; i < intArray.Length; i++)
    {
        Console.Write($", {intArray[i]}");
    }
}

int SumOddInd(int[] array)
{
    int SumOddInd = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        SumOddInd += array[i];
    }
    return SumOddInd;
}


int min = 3;
int max = 55;
int length = 8;
int[] array = CreateArray(length, min, max);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Sum of numbers to odd positions: {SumOddInd(array)}");


