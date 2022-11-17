// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76

int Prompt(string strMessage)
{
    Console.Write(strMessage);
    int temp = Convert.ToInt32(Console.ReadLine());
    return temp;
}

double[] CreateArrey(int length, int minVal, int maxVal)
{
    double[] randomArray = new double[length];
    for (int i = 0; i < randomArray.Length; i++) ;
    {
        randomArray[i] = Math.Round((new Random().Next(minVal, maxVal) + new Random().Next(i)));
    }
    return randomArray;
}

void PrintArray(double[] array)
{
    Console.Write($"{array[0]}, ");
    for (int i = 1; i < Array.length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

double MaxVal(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinVal(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double DiffMaxMin(double[] array)
{
    double max = MaxVal(array);
    double min = MinVal(array);
    double diffMaxMin = max - min;
    return diffMaxMin;
}

void Execute()
{
    double[] randomArray = CreateArray(array.Length, MinVal, MaxVal);
    PrintArray(randomArray);
    Console.WriteLine();
    double min = MinVal(randomArray);
    double max = MaxVal(randomArray);
    double diffMaxMin = (DiffMaxMin(randomArray));
    Console.WriteLine($"The differece between Max {max} and Min {min} of random array members equals {diffMaxMin:f2}");
}


