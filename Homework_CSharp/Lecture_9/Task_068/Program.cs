// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

int FuctionAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return FuctionAkkerman(m - 1, 1);
    else
        return FuctionAkkerman(m - 1, FuctionAkkerman(m, n - 1));
}

Console.WriteLine(FuctionAkkerman(2, 3));