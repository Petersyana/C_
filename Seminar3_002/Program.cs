// программа считает произведение всех чисел от 1 до N

System.Console.WriteLine("Введите число N  ");
int num = int.Parse(Console.ReadLine());
int work = 1;

for (int i = 1; i <= num; i++)
{
    work = work*i;
}
Console.WriteLine(work);