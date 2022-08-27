// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] arr)
{
    Console.WriteLine("Введите первую позицию:");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите вторую позицию:");
    int column = Convert.ToInt32(Console.ReadLine());
    if (row < 0 || row > arr.GetLength(0) || column < 0 || column > arr.GetLength(1))
        Console.WriteLine($"Элемента на позиции ({row},{column}) не существует");
    else Console.WriteLine($"На позиции ({row},{column}) элемент {arr[row, column]}");
}

int[,] matrix = CreateMatrix(5, 5, 1, 10);
PrintMatrix(matrix);
FindElement(matrix);