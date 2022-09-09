//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int Power(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result *= numberA;
  }
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ответ: {Power(numberA, numberB)}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumNum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    } 
    return result;
}


Console.Write("Введите число A: ");
  int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {a} = {SumNum(a)}");
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
 void PrintArray(int [] arr)
{   
    Console.Write($"[");
    for(int i = 0; i < arr.Length; i++)
      Console.Write($"{arr[i]}, ");
       Console.WriteLine($"\b\b]");  
}

int [] CreateArray(int n)
{   
    int [] arr = new int[n];
    for (int i = 0; i < n; i++)
     arr[i] = new Random().Next(-100,100);
    return arr;
}

int [] arr = CreateArray(8);
PrintArray(arr);
*/
