// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());

/* for(int i=num; i>=1; i--)
Console.Write($" {i}"); */


int Vivod(int num)
{
    Console.Write($" {num}");
    if(num<1) return 0;
    else return Vivod(num-1);
}

Vivod(num);
