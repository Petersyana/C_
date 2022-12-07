// программа задает массив из 8 элементов и выдает их на экран

Console.WriteLine("Введите 8 чисел");
int[] arr = new int[8]; // задаем массив

for (int i=0; i<8; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }
Console.WriteLine(string.Join(",", arr));

// генерация массива
// int[] arr = new int[8];
// var rnd = new Random();
// for (int i=0; i<8; i++)
//     {
//         arr[i] = rnd.Next(0,100);
//     }
// Console.WriteLine(string.Join(",", arr));
