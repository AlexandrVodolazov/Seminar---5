// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArray(int length, int min, int max)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max+1);
    }
    return tempArray;
}

void PrintArray(int[] intArray)
{
    Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        Console.Write($", {intArray[i]}");
    }
    Console.WriteLine();
}

int CheckElements (int[] tempArray)
{
    int count = 0;
    for (int i = 0; i < tempArray.Length; i ++)
    {
        if (tempArray[i] > 9 && tempArray[i] < 100)
        {
            count ++;
        }
    }
    return count;
}

int len = 5;
int min = 5;
int max = 100;

int[] array = CreateArray(len, min, max);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(CheckElements(array));




