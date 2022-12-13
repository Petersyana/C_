// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

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
            Console.Write($" {inArray[i,j]}  ");
        }
        Console.WriteLine();
    }
}

PrintArray(array);

// ищем среднее арифметическое по каждому столбцу

double[] sredArifmetiNum = new double[n]; // создаем массив из средарифмет. по столбцам
double sum = 0;
for (int i = 0; i<m; i++)
{
    for (int j = 0; j<n; j++)
   {
    sredArifmetiNum[j] = (sum + array[i,j])/(m);
    sum = sum + array[i,j];
   }
}

void PrintSredArifmetiNum(double[] array) // вывод массива сред.ариф. чисел по столбцам 
{
    for (int j = 0; j<n; j++) 
    Console.Write($"{sredArifmetiNum[j]} | ");
}
Console.WriteLine();
Console.WriteLine("Среднее арифметическое по столбцам");
Console.WriteLine();

PrintSredArifmetiNum(sredArifmetiNum);
