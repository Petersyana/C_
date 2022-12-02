// программа получает на ввод 2 числа и выводит, какое из них меньше и больше
// a = 5; b = 7   a = 2 b = 10   a = -9 b = -3 

Console.WriteLine("Введите первое число - ");
string firstNum = Console.ReadLine();
int num1 = Convert.ToInt32(firstNum);

Console.WriteLine("Введите второе число - ");
string secondNum = Console.ReadLine();
int num2 = Convert.ToInt32(secondNum);

if (num1 > num2)
    {
        Console.WriteLine($"{num1} > {num2}");
    }
    else
     {
        Console.WriteLine($"{num2} > {num1}");
    }