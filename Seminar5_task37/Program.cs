// программа в одномерном массиве считает произведение пар элементов:
// первого и последнего, второго и предпоследнего и т.д.

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

// метод считает произведение пар элементов:
// первого и последнего, второго и предпоследнего и т.д.

 int[] PrintArray(int[] array)
 {
    Console.WriteLine();
    Console.Write("Массив произведений пар элементов   "); 
    Console.WriteLine();
    int size = 0;
    int [] proizved_res = new int[size];

    if (res.Length%2 == 0) size = res.Length/2; // вычисляем длину нового массива (четное кол-во элементов)
    else size = res.Length/2+1; // длина для массива из нечетного кол-ва элементов
       
        for (int j = 0; j < size; j++)
        {
            if (j != res.Length-1-j) // проверяем, если середина для массива из нечетного кол-ва элементов
        proizved_res[j] = res[j]*res[res.Length-1-j];
            else proizved_res[j] = res[j]; // средний элемент = самому себе

        Console.Write($" {j} - {proizved_res[j]} ");
        }
    return proizved_res;
    Console.WriteLine();
}

  PrintArray(res); // вызов метода 

