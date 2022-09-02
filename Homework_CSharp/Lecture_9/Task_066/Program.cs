// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumElements(int start, int end)
{
    if (start > end) return 0;

    return start + SumElements(start + 1, end);
}

System.Console.WriteLine(SumElements(4, 8));