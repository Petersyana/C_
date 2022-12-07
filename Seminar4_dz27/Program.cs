// программа принимает на вход число и выдает сумму цифр в числе

Console.WriteLine("Введите число - ");
int num = int.Parse(Console.ReadLine());

int summa_num = 0;
int ost_num = 0;


for (int i = num; num>0;)
    {
        ost_num = num%10;
        summa_num = summa_num + ost_num;
        num = num/10;
    }
    summa_num = summa_num + num;
Console.WriteLine($"Сумма цифр введенного числа = {summa_num}");
