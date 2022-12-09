// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

// метод создает массив
double [] GetArray(int size)
{
Console.Write("Заданный массив   ");

    double [] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble();
        Console.Write($"{res[i]} ");
    }    
      return res;
      Console.WriteLine();
 }

   double[] res = GetArray(9); // вызов метода создания массива

   Console.WriteLine(); // переход на другую строку

// метод считает разницу между максимальным и минимальным элементом


void DiffArray(double[] array)
 {
    double maxNum = array[0];
    double minNum = array[0];
    
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