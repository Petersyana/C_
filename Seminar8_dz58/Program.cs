// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

// создание случайного массива

Console.Write("Введите количество строк массива m= ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива n= ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n]; 
int[,] array2 = new int[m,n];
int[,] result = new int[m,n];

int[,] newArray = NewArray(array);
int[,] newArray2 = NewArray(array2);


int[,] NewArray(int[,] array) // метод создания массива
{
for (int i = 0; i<m; i++)
{
    for (int j = 0; j<n; j++)
   {
    array[i,j] = new Random().Next(0,9);
    }
}
return array;
}

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

Console.WriteLine("Исходный массив 1");
PrintArray(newArray);

Console.WriteLine();

Console.WriteLine("Исходный массив 2");
PrintArray(newArray2);

int sum = 0; // сумма элементов по строке во 2 массиве
int tempJ = 0; // индекс для подсчета суммы по строке во 2 массиве

int[,] ResultArray(int[,] array) // метод перемножения массива
{
for (int i = 0; i<m; i++)
{
    for (int j = 0; j<n; j++)
   {
    for (tempJ = 0; tempJ < n; tempJ++)
    {
    sum = sum + newArray2[i,tempJ];
    }
    array[i,j] = sum * newArray[i,j]; 
    tempJ = 0;
    sum = 0;
    }
}
return array;
}

int[,] resultArray = ResultArray(result);
Console.WriteLine();

Console.WriteLine("Массив - произведение");
PrintArray(resultArray);