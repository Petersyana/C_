// программа получает на вводе число N и выдает квадраты всех чисел от 1 до этого N

Console.Clear();
Console.WriteLine("Введите число");

int num = int.Parse(Console.ReadLine());
int count = 1;
double result = 0;

while (count < num) 
    {
       result = Math.Pow(count,2); 
        Console.WriteLine(result); 
        count++;       
    }
