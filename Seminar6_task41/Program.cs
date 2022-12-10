// Программа, которая переводит десятичное число в двоичное

Console.WriteLine("Введите число - ");
int num = int.Parse(Console.ReadLine());
int i=0;
int res = 0;
int ostatok = 0;


while (num > 0)
{
    ostatok = num%2;
    num = num/2;
    
    Console.Write(ostatok);
    
}

//Console.WriteLine(res);
    

