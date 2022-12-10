// программа принимает 3 числа и проверяет, может ли существовать треугольник с такими сторонами
// каждая сторона треугольника < суммы двух других сторон

Console.WriteLine("Введите три числа через Enter - ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

Boolean isRes(int a, int b, int c)
{
    return a+b>c && a+c>b && b+c>a;
}
if (isRes(num1, num2, num3)) 
{
Console.WriteLine("Треугольник с такими сторонами может существовать");
}
else  Console.WriteLine("Треугольник с такими сторонами НЕ может существовать");

