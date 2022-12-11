// Программа, которая переводит десятичное число в двоичное

Console.WriteLine("Введите число - ");
int num = int.Parse(Console.ReadLine());

int print_num = num; // запоминаем число для вывода на печать в результате вычислений
int count = 0; // считаем длину массива из 0 и 1
int temp_num = num; // доп переменная для подсчета длины массива


// доп цикл для подсчета длины массива с 0 и 1
while (temp_num > 0) 
{
    temp_num = temp_num/2;
    count ++;
}


int i = 0;
int [] res = new int[count];
int ostatok = 0;

// цикл переводит десятичное число в двоичное

while (num > 0) 
{
    ostatok = num%2;
    num = num/2;
    res[i] = ostatok; // массив из 0 и 1
    i ++;
}

// метод переворачивает массив

 int[] PerevorotArray(int[] array)
 {
    int temp = array[0];

    for (int j = 0; j < array.Length/2; j++)
       {
        temp = array[j];
        array[j] = array[array.Length-1-j];
        array[array.Length-1-j] = temp;
        }
    return array;
    Console.WriteLine();
}

  PerevorotArray(res); // вызов метода переворота
 
Console.Write($"Число {print_num} в десятичном формате - "); 
Console.Write(String.Join(" ",res));

    

