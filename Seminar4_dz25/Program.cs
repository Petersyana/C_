// программа принимает на вход числа А и В и выдает число А в степени В

Console.WriteLine("Введите число А - ");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B - ");
int numB = int.Parse(Console.ReadLine());

int result = numA;

for (int i = 1; i < numB; i++)
    {
        result = result*numA;
    }
Console.WriteLine($"число A={numA} в степени B={numB} = {result}");