// // Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// // Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// // Результат запишите в новом массиве.
// // [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21

int[] CreateArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void CompositionOfNumbers(int[] arr)
{
    //int[]array = new int [arr.Length / 2];
    int j = arr.Length - 1;
    for (int i = 0; i < arr.Length  / 2; i++)
    {
        
        //Console.Write($"{arr[i] * arr[j]} ");
        arr[i] *= arr[j];
        j--;
    }
    //return arr;

    // for (int i = 0; i < (arr.Length + 1) / 2; i++)
    // {
    //     for (int j = arr.Length - 1; j > arr.Length / 2; j--)
    //     {
    //         Console.Write($"({arr[i]} * {arr[j]}) ");
    //     }
    // }
    // return arr;
}
int[] array = CreateArray(10, 1, 10);
PrintArray(array);
CompositionOfNumbers(array);
PrintArray(array);

// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// int[] CreateArray(int length, int min, int max)
// {
//     int[] arr = new int[length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int FindCountPositiveNumbers(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int[] arr = CreateArray(7, 100, 999);
// PrintArray(arr);
// int count = FindCountPositiveNumbers(arr);
// Console.WriteLine($"Количество положительных чисел равно {count}");


// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// int[] CreateArray(int length, int min, int max)
// {
//     int[] arr = new int[length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int SumOddElements(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i = i + 2)
//     {
//         sum += arr[i]; 
//     }
//     return sum;
// }

// int[] arr = CreateArray(7, 1, 9);
// PrintArray(arr);
// int sum = SumOddElements(arr);
// Console.WriteLine($"Сумма элементов на нечетных позициях равна {sum}");

// // Задача 38: Задайте массив вещественных чисел. 
// // Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76

// double[] CreateArray(int number)
// {
//     double[] arr = new double[number];

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().NextDouble() * 10;
//     }
//     return arr;
// }

// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Math.Round(array[i], 1);
//         Console.Write($"{array[i]}; ");
//     }
//     Console.WriteLine();
// }

// double FindDifference(double[] arr)
// {
//     double min = arr[0];
//     double max = arr[0];
//     double difference = 0;
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] > max) max = arr[i];
//         if (arr[i] < min) min = arr[i];
//         difference = max - min;
//         difference = Math.Round(difference, 1);
//     }
//     return difference;
// }
// double[] array = CreateArray(6);
// PrintArray(array);
// double diff = FindDifference(array);
// System.Console.WriteLine(diff);