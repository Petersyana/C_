// программа создает копию массива поэлементным копированием

Console.Clear();

// метод создает массив

int[] GetArray(int size, int minNum, int maxNum)
{
Console.Write("Заданный массив   ");

    int [] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minNum, maxNum+1);// +1,чтобы последнее число вошло в массив
        Console.Write($"{res[i]} ");
    }    
      return res;
      Console.WriteLine();
 }

   int[] res = GetArray(9,0,200); // вызов метода создания массива

   Console.WriteLine(); // переход на другую строку

// метод поэлементно копирует массив

int[] CopyArray(int[] array)
{
Console.Write("Скопированный массив   ");

    int [] res1 = array; // задаем массив, который равен массиву-аргументу

    for (int i = 0; i < array.Length; i++)
    {
        res1[i] = res[i];
        Console.Write($"{res[i]} ");
    }    
      return res1;
    Console.Write(String.Join(" ", res1));
 }

  CopyArray(res);

  
