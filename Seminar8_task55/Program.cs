// Программа меняет строки на столбцы

// создание случайного массива

Console.Write("Введите количество строк массива m= ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива n= ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];

for (int i = 0; i<m; i++)
{
    for (int j = 0; j<n; j++)
   {
    array[i,j] = new Random().Next(10,99);
    }
}

Console.WriteLine("Исходный массив");
PrintArray(array);

Console.WriteLine();
Console.WriteLine();

// меняем местами строки и стобцы

int[,] newArray = ChangeArray(array);

int[,] ChangeArray(int[,] array)
{ 
int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];

for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
    {
    newArray[j,i] = array[i,j];
    }
}
return newArray;
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

Console.WriteLine("Поменяли строки на столбцы");
PrintArray(newArray);
