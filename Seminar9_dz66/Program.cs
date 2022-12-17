// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Для нахождения суммы чисел от А до Б используется формула: (a+b)×(b-a+1)/2

Console.WriteLine("Введите числа M < N через Enter");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

/* int sum = 0;
for(int i=m; i<n; i++)
sum = sum+i;
Console.Write($" {sum}");  */


int SumNum(int m, int n)
{
     if(m==n) return 0;
     else return m + SumNum(m + 1, n);
    
 // return m == n? n : m + SumNum(m + 1, n); в одну строку
}

Console.Write($"Сумма чисел от M = {m} до N = {n} равна {SumNum(m,n)}");