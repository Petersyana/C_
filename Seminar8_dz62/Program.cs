// заполнение массива по спирали

int n = 4;
int x = 0; 
int y = 0;

int[,] array = new int[n,n]; //создаем массив из 0
for (x = 0; x < n; x++)
{
    for (y = 0; y < n; y++)
    {
        array[x,y] = 0;
    }
}

int num = 1;
x = 0; 
y = -1;
int d_column = 1; //-1 0 1
int d_row = 0; // -1 0 1

while(num < Math.Pow(n,2))
{
    if ((0 <= x+d_row & x+d_row < n) & (0 <= y+d_column & y+d_column < n) & (array[x+d_row, y+d_column] == 0))
    {     
    x += d_row;
    y += d_column;
    Console.WriteLine($"{x},{y}");
    array[x,y] = num;
    num +=1;
    }
    if (d_column == 1)
        {
            d_column = 0;
            d_row = 1;
            Console.WriteLine("first");
        }
    }
       /*  if(d_row == 1)
           {
           d_column = -1;
            d_row = 0; 
            }
              if(d_column == -1)
                {
                    d_column = 0;
                    d_row = -1;
                }
            if(d_row == -1)
                {
                d_column = 1;
                    d_row = 0; 
                } */
            
          

void PrintArray(int[,] inArray) // вывод на печать
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(array);