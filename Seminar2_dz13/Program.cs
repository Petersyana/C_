// программа, которая выводит третью цифру заданного числа или пишет, что такой цифры нет

Console.WriteLine("Введите любое число - ");
string enterNum = Console.ReadLine();

int amount = enterNum.Length; // кол-во символов(цифр) в числе
if (amount < 3)  
    {
    Console.WriteLine($"В данном числе {enterNum} кол-во цифр меньше трех");
    }
else
    {
    Console.Write($"В данном числе {enterNum} третья по счету цифра - ");
    Console.WriteLine(enterNum.Substring(2, 1));
    }