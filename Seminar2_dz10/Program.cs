// программа принимает на входе трехзначное число и на выходе показывает 2 цифру этого числа

Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
int num1 = num % 100;
int num2 = (num1 - num % 10)/10;
Console.WriteLine(num2);
