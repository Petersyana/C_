// программа задает массив из 123 элементов
// и определяет кол-во элементов из отрезка [10,99]

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

   int[] res = GetArray(123,0,200); // вызов метода создания массива

   Console.WriteLine(); // переход на другую строку

// метод определяет кол-во элементов из отрезка [10,99]

 void PrintArray(int[] array)
 {
    int count_num = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (res[i] >= 10 & res[i] <=99) count_num += 1;
    } 
    Console.WriteLine($"Количество элементов из интервала [10,99] = {count_num}");
 }

  PrintArray(res); // вызов метода
