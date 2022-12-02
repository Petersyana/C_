// пишем программку, которая считает квадрат введенного числа

Console.WriteLine("Enter number: ");
string enterNum = Console.ReadLine();
int num = Convert.ToInt32(enterNum);

int sqr = num * num;

Console.WriteLine($"sqr= {sqr}");