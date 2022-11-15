// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int PromptInt(string strMessage)
{
    Console.Write(strMessage);
    int temp = int.Parse(Console.ReadLine());
    return temp;
}

int[] CreateArray(int length)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(-9, 10);
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

bool IsHasNumber(int number, int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return true;
        }
    }
    return false;
}

int[] array = CreateArray(10);

PrintArray(array);

int number = PromptInt($" Enter the number to be found: ");

if (IsHasNumber(number, array))
{
    Console.WriteLine($"YES");
}
else
{
    Console.WriteLine($"NO");
}


