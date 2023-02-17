// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Input number");
// while(true)
// {
  int a = Convert.ToInt32(Console.ReadLine());
//   if (a > 0 && a < 5)
//   break;
// }
switch (a)
 {
    case 1:
           System.Console.WriteLine("[x > 0 y > 0]"); 
           break;
    case 2:
           System.Console.WriteLine("[x > 0 y < 0]"); 
           break;
    case 3:
           System.Console.WriteLine("[x < 0 y < 0]"); 
           break;
    case 4:
           System.Console.WriteLine("[x > 0 y < 0]"); 
           break;
    default: 
      System.Console.WriteLine("Такой координатной плоскости не существует");
      break;
 }


