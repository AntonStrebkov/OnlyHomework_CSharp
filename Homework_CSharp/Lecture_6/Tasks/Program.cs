// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел, которые хотите ввести");
int lengthNumbers = Convert.ToInt32(Console.ReadLine());
if (lengthNumbers < 0)
    Console.WriteLine("Введите положительное число");

int[] FavouriteNumbers()
{
    int[] arr = new int[lengthNumbers];
    for (int i = 0; i < lengthNumbers; i++)
    {
        Console.WriteLine($"Введите {i + 1} число");
        int n = Convert.ToInt32(Console.ReadLine());
        arr[i] = n;
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

int CompareNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int[] array = FavouriteNumbers();
PrintArray(array);
int count = CompareNumbers(array);
Console.WriteLine($"Пользователь ввел {count} чисел(ла) больше нуля");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
double x = (b2 - b1)/(k1 - k2);
double y = k2 * x + b2;
Console.WriteLine($"Пересечение прямых в точке X: {x}, Y: {y}");