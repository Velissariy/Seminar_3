// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


double [] a = new double [4]; 
Console.WriteLine("Input x1");
double x1 = Convert.ToInt32(Console.ReadLine());
a [0] = x1;
Console.WriteLine("Input y1");
double y1 = Convert.ToInt32(Console.ReadLine());
a [1] = y1;
Console.WriteLine("Input x2");
double x2 = Convert.ToInt32(Console.ReadLine());
a [2] = x2;
Console.WriteLine("Input y2");
double y2 = Convert.ToInt32(Console.ReadLine());
a [3] = y2;


double result = Math.Sqrt((a[0]-a[2])*(a[0]-a[2])+(a[1]-a[3])*(a[1]-a[3]));
Console.WriteLine(result);