// программа, кото выводит массив из 8 эелементов,
// заполненный 0 и 1 в произвольном порядке

// Console.WriteLine();
// int[] arr = new int[8];
// int i = 0;

// for (; i<8; i++)
// {
//     var rnd = new Random();
//     arr[i] = rnd.Next(0,2);
// }
// //Console.Write(arr[i]+"_");

// Console.WriteLine(stringJoin(",",arr));

int[] array = new int[8];
var random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 2);
}
Console.WriteLine(string.Join(", ", array));
