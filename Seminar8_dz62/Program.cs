// заполнение массива по спирали

int n = 4;
int x = 0; 
int y = 0;

int[,] array = new int[n,n]; //создаем массив из 0
// for (x = 0; x < n; x++)
// {
//     for (y = 0; y < n; y++)
//     {
//         array[x,y] = 0;
//     }
// }

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

//PrintArray(array);

int num = 1;
int n1 = 1;
x = 0; 
y = 1;
int d_column = 1; //-1 0 1
int d_row = 0; // -1 0 1


// while(n1 < n*2)
// {
//     if ((x <= n) && (y <= n))
//     {
//     array[x,y] = num;
//     Console.Write($" {num}");
//     x = x + d_row;
//     y = y + d_column;
//     num = num+1;
    
//     }
// //}











    if ((0 <= x+d_row && x+d_row < n) && 
    (0 <= y+d_column && y+d_column < n) && 
    (array[x+d_row, y+d_column] == 0))
    {     
        x += d_row;
        y += d_column;
        Console.Write($" {num}");
        array[x,y] = num;
        num +=1; 
    }

    //  if (d_column == 1)
    //     {
    //         d_column = 0;
    //         d_row = 1;
    //         Console.Write($" {num}");
    //      }
// }
// else
//         if(d_row == 1)
//            {
//            d_column = -1;
//             d_row = 0; 
//            //}
//     else
//             if(d_column == -1)
//                 {
//                     d_column = 0;
//                     d_row = -1;
//               //  }
//          else
//                 if(d_row == -1)
//                 {
//                 d_column = 1;
//                     d_row = 0; 
//                 } 
//                 }
//            }
//         }
//      }
// }
            
            
          

PrintArray(array);