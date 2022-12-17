// простой калькулятор

Console.WriteLine("Введите математическое выражение - ");
string str = (Console.ReadLine());

string[] separators = {"+","-","*","/","="};

string[] subs = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine(subs[0]);



