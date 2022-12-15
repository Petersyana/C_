// программа в массиве меняет местами первую и последнюю строки

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

int temp = 0;

for (int j = 0; j < array.GetLength(1); j++)
{
    temp = array[0,j];
    array[0,j] = array[m-1,j];
    array[m-1,j] = temp;
}

void PrintArray(int[,] inArray)
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

Console.WriteLine("Поменяли первую строку на последнюю");
PrintArray(array);