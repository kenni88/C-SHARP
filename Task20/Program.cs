// Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки А");
Console.Write("Введите координату Xa");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Ya");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("Введите координату Xb");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Yb");
int yB = Convert.ToInt32(Console.ReadLine());

double Length = Distance(xA,yA,xB,yB);
Console.WriteLine(Math.Round(Length, 2, MidpointRounding.ToZero));

double Distance(int x1,int y1, int x2, int y2)
{
 return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
}



//Math.Sqrt(5);
//double d = 5.09987354;
//double dRound = Math.Round (d, 2, MidpointRounding.ToZero);
//Console.WriteLine(dRound);

