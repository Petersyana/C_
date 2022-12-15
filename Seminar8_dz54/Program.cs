// Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

// создание случайного массива

Console.Write("Введите количество строк массива m= ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива n= ");
int n = int.Parse(Console.ReadLine());

int[,] array1 = new int[m,n]; 
int[,] newArray = new int[m,n];

int[,] NewArray(int[,] array) // метод создания массива
{
for (int i = 0; i<m; i++)
{
    for (int j = 0; j<n; j++)
   {
    array[i,j] = new Random().Next(10,99);
    }
}
return array;
}

NewArray(array1);

void PrintArray(int[,] inArray) // вывод на печать
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

Console.WriteLine("Исходный массив");
PrintArray(array1);

int temp = 0; // переменная "карман"

int[,] SortArray(int[,] array) // метод сортирует в каждой строке по убыванию
{
for (int i = 0; i < m; i++)
{
    for(int j = 0; j < n-1; j++)
    {
        for(int k = 0; k <  n-1; k++)
        {
            if (array[i,k] < array[i,k+1])
            {
            temp = array[i,k];
            array[i,k] = array[i,k+1];
            array[i,k+1] = temp;
            }
        }
    }
}
return array;
}

newArray = SortArray(array1);

Console.WriteLine("Отсортированный массив");
PrintArray(newArray);