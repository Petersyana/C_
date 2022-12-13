// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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
Console.WriteLine();

void PrintArray(int[,] inArray) // метод печати массива
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
