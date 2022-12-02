// программа выдает название дня недели, по его номеру

Console.WriteLine("Введите номер дня недели (число от 1 до 7) - ");
string NumDayWeek = Console.ReadLine();
int numDay = Convert.ToInt32(NumDayWeek);

if (numDay < 1|numDay > 7)
    {
        Console.WriteLine("В неделе 7 дней! число должно быть от 1 до 7!");
    }

if (numDay == 1)
    {
        Console.WriteLine("ПОНЕДЕЛЬНИК");
    }

if (numDay == 2)
    {
        Console.WriteLine("ВТОРНИК");
    }

if (numDay == 3)
    {
        Console.WriteLine("СРЕДА");
    }

if (numDay == 4)
    {
        Console.WriteLine("ЧЕТВЕРГ");
    }

if (numDay == 5)
    {
        Console.WriteLine("ПЯТНИЦА");
    }

if (numDay == 6)
    {
        Console.WriteLine("СУББОТА");
    }

if (numDay == 7)
    {
        Console.WriteLine("ВОСКРЕСЕНЬЕ");
    }