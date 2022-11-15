// Создать массив и посчитать среднее значение.


int[] CreateArr(int min = 0, int max = 10, int len = 10)
{
    int[] arr = new int[len];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

double Average(int[] arr)
{
    double total = 0;
    foreach (int item in arr)
    {
        total += item;
    }
    return total / arr.Length;
}

double MiddleSquare(int[] arr)
{
    double total = 0;
    foreach (var item in arr)
    {
        total += Math.Pow(item, 2);
    }
    return Math.Sqrt(total / arr.Length);
}

void PrintArr(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item}");
    }
}

void Runner()
{
    int[] numbers = CreateArr();
    double result = Average(numbers);
    double resSqr = MiddleSquare(numbers);
    PrintArr(numbers);
    Console.WriteLine();
    Console.WriteLine(result);
    Console.WriteLine($"{resSqr:f2}");
}

Runner();




