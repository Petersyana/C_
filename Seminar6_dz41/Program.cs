// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько введете чисел? - ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Введите {n} чисел через Enter" );

int count = 0;
for (int i=0; i<n; i++)
{
if (int.Parse(Console.ReadLine()) > 0) count=count+1;
}
Console.WriteLine($" Кол-во чисел > 0 = {count}");