// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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

void CompositionMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                resultMatrix[i, j] = resultMatrix[i, j] +
                (firstMatrix[i, k] * secondMatrix[k, j]);
            }
            Console.Write($"{resultMatrix[i, j]}\t");
        }
        Console.WriteLine();
    }

}

int[,] firstMatrix = CreateMatrix(2, 2, 1, 5);
int[,] secondMatrix = CreateMatrix(2, 2, 1, 5);
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
CompositionMatrix(firstMatrix, secondMatrix);
