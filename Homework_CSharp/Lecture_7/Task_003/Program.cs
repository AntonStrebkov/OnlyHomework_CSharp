// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] matrix = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; ++row)
    {
        for (int column = 0; column < columnCount; ++column)
        {
            matrix[row, column] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FindMiddle(int[,] array)
{
    double[] sum = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum[i] += array[j, i];
        }
    }
    for (int i = 0; i < array.GetLength(1); i++)
    {
        System.Console.Write($"{sum[i]}\t");
    }
    System.Console.WriteLine();
    for (int k = 0; k < array.GetLength(1); k++)
    {
        double oneSumNum = Math.Round(sum[k] / array.GetLength(0), 2);
        Console.Write($"{oneSumNum}\t");
    }
}

int[,] matrix = CreateMatrix(7, 8, 1, 10);
PrintMatrix(matrix);
Console.ForegroundColor = ConsoleColor.Blue;
FindMiddle(matrix);
Console.ResetColor();