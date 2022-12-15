// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// создание случайного массива

Console.Write("Введите 1 измерение для массива m= ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите 2 измерение для массива n= ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите 3 измерение для массива k= ");
int k = int.Parse(Console.ReadLine());

int[,,] array = new int[m,n,k]; 

int[,,] newArray = NewArray(array);


int[,,] NewArray(int[,,] array) // метод создания массива
{
for (int ind1 = 0; ind1 < m; ind1++)
{
    for (int ind2 = 0; ind2 < n; ind2++)
   {
    for (int ind3 = 0; ind3 < k; ind3++)
    {
    array[ind1,ind2,ind3] = new Random().Next(0,9);
    }
    }
}
return array;
}

void PrintArray(int[,,] inArray) // вывод на печать
{
    for (int ind1 = 0; ind1 < m; ind1++)
    {
        for (int ind2 = 0; ind2 < n; ind2++)
        {
            for (int ind3 = 0; ind3 < k; ind3++)
        {
            Console.Write($" {inArray[ind1,ind2,ind3]} ({ind1}, {ind2}, {ind3}) ");
        }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Исходный массив");
PrintArray(newArray);

Console.WriteLine();