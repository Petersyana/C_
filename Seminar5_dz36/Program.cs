// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

// метод создает массив

int[] GetArray(int size, int minNum, int maxNum)
{
Console.Write("Заданный массив   ");

    int [] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minNum, maxNum);
        Console.Write($"{res[i]} ");
    }    
      return res;
      Console.WriteLine();
 }

   int[] res = GetArray(9,10,30); // вызов метода создания массива

   Console.WriteLine(); // переход на другую строку

// метод считает сумму элементов, стоящих на нечётных позициях.

void PrintArray(int[] array)
 {
    int sum = 0;
    for (int i = 1; i < array.Length; i=i+2) 
    {
        sum=sum+array[i];
    } 
  Console.WriteLine($"Сумма чисел на нечетных позициях = {sum}");
 }

  PrintArray(res); // вызов метода 