// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

double[,] CreateMatrix(int row, int column)
{
    double[,] array = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
            Math.Round(array[i, j], 2);
        }
    }
    return array;
}

void PrintMatrix(double[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            double numberMatrix = Math.Round(arr[row, column], 1);
            Console.Write(numberMatrix + "\t");

        }
        Console.WriteLine();
    }
}
double[,] matrix = CreateMatrix(10, 6);
PrintMatrix(matrix);

