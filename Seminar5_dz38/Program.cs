// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

// метод создает массив

int [] GetArray(int size, int minNum, int maxNum)
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

// метод считает разницу между максимальным и минимальным элементом


void DiffArray(int[] array)
 {
    int maxNum = array[0];
    int minNum = array[1];
    
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > maxNum) maxNum = array[i];
        if (array[i] < minNum) minNum = array[i];
    } 
  Console.WriteLine($"Максимальное число в массиве = {maxNum}");
  Console.WriteLine($"Минимальное число в массиве = {minNum}");
  Console.WriteLine($"Разница между этими числами = {maxNum - minNum}");
 }

  DiffArray(res); // вызов метода 