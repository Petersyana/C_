// программа упорядочивает массив от мах к мин

int[] arr = {3,8,7,6,14,9,5};

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int maxPosition = 0;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;            
        }
    int temp = array[i];
    array[i] = array[maxPosition];
    array[maxPosition] = temp;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{array[i]} ");
        }
Console.WriteLine();
}

SelectionSort(arr);
PrintArray(arr);