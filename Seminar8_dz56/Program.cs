// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// создание случайного массива

Console.Write("Введите количество строк массива m= ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива n= ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n]; 
int[,] newArray = NewArray(array);

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
PrintArray(newArray);

int[] sum = new int[m]; // считаем сумму по строкам

for (int i=0; i<m; i++)
{
    for(int j=0; j<n; j++)
    {
    sum[i] = sum[i] + newArray[i,j];
    }
}

int min = sum[0];
int minI = 0;

for(int i=0; i<m; i++)
{
    if(sum[i] < min) 
    {
        min = sum[i]; 
        minI = i;
    }
}

Console.Write($"В строке {minI+1} min сумма элементов = {min}");