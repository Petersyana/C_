// программа определяет, присутствует ли в массиве заданный элемент
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

// метод ищет число в массиве

 void PrintArray(int[] array)
 {
    Console.WriteLine("Введите число ");
    int num = int.Parse(Console.ReadLine());

 for (int i = 0; i < array.Length; i++) 
    {
        if (res[i] == num) 
                Console.WriteLine($"число {num} присутствует в массиве");
        else    Console.WriteLine($"число {num} отсутствует в массиве");
        break;        
    } 
 }

  PrintArray(res); // вызов метода
