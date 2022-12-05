// программа, которая принимает на вход цифру,  обозначающую день недели, 
// и проверяет, является ли этот день выходным

Console.WriteLine("Введите число дня недели (от 1 до 7)");
int num_day = int.Parse(Console.ReadLine());
if (num_day == 6 || num_day==7)
    {
        Console.WriteLine("этот день - выходной :))");
    }
else
    {
       Console.WriteLine("этот день - будни :(("); 
    }    
