// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/* Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
 */

//var array = 

Console.Write("Введите количество строк массива: ");
var rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

int[,] array = new int [rows,columns];

for (int i =0; i<rows; i++)
{
    for (int j=0; j<columns; j++)
   {
    array[i,j] = new Random().Next(0,9);
    Console.Write((array[i,j])+" ");    
   }

Console.WriteLine();
}

void MethodSqrt(int[,] array)
{
for (int i = 0; i<rows; i++)
{
    for (int j = 0; j<columns; j++)
   {
     if (i%2 == 0 && j%2 == 0)
     {
     array[i,j] = Convert.ToInt32(Math.Pow(array[i,j],2));
     }
   }

Console.WriteLine();
}
}

MethodSqrt(array);

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


PrintArray(array);