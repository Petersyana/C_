// программа, которая считает расстояние между двумя точками по их координатам в 3d

Console.Write("Для точки А введите значение координаты Х=  ");
int Xa = int.Parse(Console.ReadLine());

Console.Write("Для точки А введите значение координаты Y=  ");
int Ya = int.Parse(Console.ReadLine());

Console.Write("Для точки А введите значение координаты Z=  ");
int Za = int.Parse(Console.ReadLine());
  
Console.Write("Для точки B введите значение координаты Х=  ");
int Xb = int.Parse(Console.ReadLine());

Console.Write("Для точки B введите значение координаты Y=  ");
int Yb = int.Parse(Console.ReadLine());

Console.Write("Для точки B введите значение координаты Z=  ");
int Zb = int.Parse(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow((Xb - Xa),2) + Math.Pow((Yb - Ya),2) + Math.Pow((Zb - Za),2));

Console.Write($"Расстояние между точками АВ в 3D = {AB}");


