// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

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

bool IsInArray(int row,int column, int[,]inArray)
{
    if(row<inArray.GetLength(0)&&column<inArray.GetLength(1)) return true;
    else return false;
}

int[,]array=GetArray(5,5,0,10);
Console.WriteLine("полученный массив: ");
PrintArray(array);
Console.Write("введите индекс строки ");
int rowIndex=int.Parse(Console.ReadLine()!);
Console.Write("введите индекс столбца ");
int columnIndex=int.Parse(Console.ReadLine()!);
if(IsInArray(rowIndex,columnIndex,array))Console.WriteLine($"значение заданного элемента: {array[rowIndex,columnIndex]}");
else Console.WriteLine("такого элемента в массиве нет");