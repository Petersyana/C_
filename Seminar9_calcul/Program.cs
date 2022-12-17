

// Калькулятор 1

Console.WriteLine("Введите через Enter первое число, оператор (+, -, *, /) и второе число:");
double input1 = Convert.ToDouble(Console.ReadLine());
string input2 = Console.ReadLine();
double input3 = Convert.ToDouble(Console.ReadLine());

double output = 0;

if (input2 == "*") output = input1 * input3;
if (input2 == "/") output = input1 / input3;
if (input2 == "-") output = input1 - input3;
if (input2 == "+") output = input1 + input3;

Console.WriteLine($"{input1} {input2} {input3} = {output}");


// второй вариант

double firstNum;
double secondNum;
string operation;
double result;

Console.Clear();
Console.WriteLine("Первое число: ");
firstNum = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Действие %, *, /, +, - : ");
operation = Convert.ToString(Console.ReadLine());
Console.WriteLine("Второе число: ");
secondNum = Convert.ToDouble(Console.ReadLine());
if (operation == "+")
{

    result = firstNum + secondNum;
    Console.WriteLine("Результат: " + result);

}

if (operation == "-")
{

    result = firstNum - secondNum;
    Console.WriteLine("Результат: " + result);

}

if (operation == "*")
{

    result = firstNum * secondNum;
    Console.WriteLine("Результат: " + result);

}

if (operation == "/")
{

    result = firstNum / secondNum;
    Console.WriteLine("Результат: " + result);
}
