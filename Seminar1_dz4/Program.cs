// программа выводит большее из трех введенных чисел
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число - ");
string firstNum = Console.ReadLine();
int num1 = Convert.ToInt32(firstNum);

Console.WriteLine("Введите второе число - ");
string secondNum = Console.ReadLine();
int num2 = Convert.ToInt32(secondNum);

Console.WriteLine("Введите третье число - ");
string threeNum = Console.ReadLine();
int num3 = Convert.ToInt32(threeNum);

int max = num1;

if (num2 > max)
    {
      max = num2;  
    }

if (num3 > max)
    {
      max = num3;  
    }

Console.WriteLine($"max = {max}");