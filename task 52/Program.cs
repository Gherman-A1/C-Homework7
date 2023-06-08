//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetAverage(int[,]inArray)
{
    int sum=0;
    double average=0;
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        sum=0;
        average=0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum=sum+inArray[i,j];
        }
        average=(double)sum/inArray.GetLength(1);

        Console.Write($"{average}, ");
    }
}

int[,]array=GetArray(5,5,0,10);
Console.WriteLine("полученный массив: ");
PrintArray(array);
Console.WriteLine("среднее арифметическое по столбцам: ");
GetAverage(array);