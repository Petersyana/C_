// программа на вводе получает два числа и проверяет, является ли первое число квадратом второго

Console.WriteLine("Введите первое число : ");
string firstNum = Console.ReadLine();
int num1 = Convert.ToInt32(firstNum);

Console.WriteLine("Введите второе число : ");
string secondNum = Console.ReadLine();
int num2 = Convert.ToInt32(secondNum);

if (num1 == num2 * num2)
    {
        Console.WriteLine($"{num1}-квадрат числа {num2}");
    }
else
    {
        Console.WriteLine("первое число не является квадратом второго числа");
    }