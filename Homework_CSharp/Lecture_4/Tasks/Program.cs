// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int number, int degree)
{
  int result = 1;
  int index = 1;
  while(index <= degree)
  {
    result = result * number;
    index++;
  }
  return result;
}


void WriteExponentiation(int number, int degree)
{
  Console.WriteLine($"{number}, {degree} -> {Exponentiation(number, degree)}");
}
WriteExponentiation(3, 5);
WriteExponentiation(2, 4);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int num)

{
 int result = 0;
 int len = num.ToString().Length;
  
 for(int i = 0; i < len ; i++)
 {
  result = result + num % 10;
  num = num / 10;
 }
 
 return result;
}

void WriteSum(int num)
{
    Console.WriteLine($"Сумма чисел {num} -> " + Sum(num));
}

WriteSum(452);
WriteSum(82);
WriteSum(9012);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int num)
{
  int[] arr = new int[num];
  
  for(int i = 0; i < num; i++)
  {
    arr[i] = new Random().Next(1, 51);
    
  }
  return arr;
}

void WriteArray(int[] arr)
{
  int len = arr.Length;
  for(int j = 0; j < len; j++)
  {
  Console.Write($"{arr[j]}, ");
  }
  Console.WriteLine();
}

WriteArray(CreateArray(8));
WriteArray(CreateArray(13));
WriteArray(CreateArray(42));





