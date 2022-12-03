// программа определяет четное число или нечетное
// 4 -3 7

Console.WriteLine("Введите число - ");
string enterNum = Console.ReadLine();
int num = Convert.ToInt32(enterNum);

if (num%2 == 0)
    {
        Console.WriteLine($"{num} - четное число");
    }
else
    {
        Console.WriteLine($"{num} - нечетное число");
    }

