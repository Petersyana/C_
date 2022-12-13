//  Напишите программу, которая на вход принимает значение элемента 
// в двумерном массиве, и возвращает значение и индекс этого элемента 
// или же указание, что такого элемента нет.

// создание случайного массива

Console.Write("Введите количество строк массива m= ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива n= ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];

for (int i =0; i<m; i++)
{
    for (int j=0; j<n; j++)
   {
    array[i,j] = new Random().Next(10,99);
    }
}

void PrintArray(int[,] inArray) // вывод массива на печать 
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(array);

// поиск заданного числа

Console.WriteLine("Введите число, которое будем искать в массиве = ");

int num = int.Parse(Console.ReadLine());
int tempI = 0;
int tempJ = 0;

for (int i = 0; i<m; i++)
{
    for (int j = 0; j<n; j++)
   {
    if (array[i,j] == num) 
    {
    tempI = i;
    tempJ = j;
    Console.Write($"Искомое число {num} найдено в массиве на позиции ({tempI},{tempJ})");
    Console.WriteLine();
    }
   }
}

if (tempI == 0 && tempJ ==0) Console.Write($"Искомое число {num} не найдено в массиве");

