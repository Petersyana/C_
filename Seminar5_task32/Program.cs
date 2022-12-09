// программа заменяет в массиве отрицательные элементы на положительные и наоборот
Console.Clear();

// метод создает массив

int[] GetArray(int size, int minValue, int maxValue)
{
Console.Write("Заданный массив   ");

    int [] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{res[i]} ");
    }    
      return res;
      Console.WriteLine();
 }

   int[] res = GetArray(4,-9,9); // вызов метода создания массива

   Console.WriteLine(); // переход на другую строку

// метод выводит массив на печать

 void PrintArray(int[] array)
 {
    Console.WriteLine("Отработанный массив");

 for (int i = 0; i < array.Length; i++) 
    {
        Console.Write($"{-1 * array[i]} ");
    } 
 }

  PrintArray(res); // вызов метода печати массива

