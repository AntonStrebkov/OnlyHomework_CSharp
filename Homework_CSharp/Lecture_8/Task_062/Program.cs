// Задача 62: Заполните спирально массив 4 на 4.

int[,] CreateArray(int row, int column)
{
    int[,] nums = new int[row, column];

    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= row * column)
    {
        nums[i, j] = num;
        if (i <= j + 1 && i + j < row - 1)
            ++j;
        else if (i < j && i + j >= row - 1)
            ++i;
        else if (i >= j && i + j > row - 1)
            --j;
        else
            --i;
        ++num;
    }
    return nums;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateArray(4, 4);
PrintArray(matrix);