// программа, которая определяет, является ли число палиндромом,
// т.е. от середины - цифры в числе зеркальные

Console.WriteLine("Введите любое 5-значное число - ");
int num = int.Parse(Console.ReadLine());
int num1 = num/10000;

int temp_num2 = num/1000;
int num2 = temp_num2%10;

int temp_num4 = num%100;
int num4 = temp_num4/10;

int num5 = num%10;

if (num1 == num5 && num2 == num4)
    Console.WriteLine($"введенное число {num} - палиндром ");
