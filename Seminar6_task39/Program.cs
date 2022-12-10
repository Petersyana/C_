// программа преворачивает массив

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

// метод переворачивает массив

 int[] PerevorotArray(int[] array)
 {
    Console.WriteLine();
    Console.Write("Перевернутый массив   "); 
   
    int temp = res[0];

    for (int j = 0; j < res.Length/2; j++)
       {
        temp = res[j];
        res[j] = res[res.Length-1-j];
        res[res.Length-1-j] = temp;
        }
    return res;
    Console.WriteLine();
    }

  PerevorotArray(res); // вызов метода 
  Console.Write(String.Join(" ", res));


