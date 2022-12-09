// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

   int[] res = GetArray(9,100,999); // вызов метода создания массива

   Console.WriteLine(); // переход на другую строку

// метод считает кол-во четных чисел

void PrintArray(int[] array)
 {
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (res[i]%2 == 0) count += 1;
    } 
  Console.WriteLine($"Количество четных чисел в массиве = {count}");
 }

  PrintArray(res); // вызов метода 
