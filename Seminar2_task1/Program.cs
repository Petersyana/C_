// программа, которая по номеру четверти (плоскость координат) выдаст 
// Х и У

Console.WriteLine("введите номер четверти в плоскости координат (от 1 до 4) - ");
int num = int.Parse(Console.ReadLine());

switch(num)
{
    case 1:
        Console.WriteLine("значения координат будут в диапазоне: Х>0, Y>0");
    break;

    case 2:
        Console.WriteLine("значения координат будут в диапазоне: Х<0, Y>0");
    break;

    case 3:
        Console.WriteLine("значения координат будут в диапазоне: Х<0, Y<0");
    break;

    case 4:
        Console.WriteLine("значения координат будут в диапазоне: Х>0, Y<0");
    break;

    default:
        Console.WriteLine("В координатной плоскости 4 четверти. Введите число от 1 до 4 ");
    break;
}
