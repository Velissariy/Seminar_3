//  Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.





int [] points = new int[2];        // тип данных в массиве_([] - это обозначает массив)_название массива //new int[2] - [2] - размер массива;
//points[0] = 1; - ручной ввод данных в массив
//points[1] = 2;



for (int i = 0; i < points.Length; i++) // автоматическое наполнение массива
 {
while(true)
{
  points[i] = Convert.ToInt32(Console.ReadLine());
   if (points[i] !=0)
   break;
   else
   Console.WriteLine("Incorrect input");
 }
 }
  if (points[0] > 0 && points[1] > 0)   // x> 0, y >0
           Console.WriteLine("1");
  else if (points[0] < 0 && points[1] > 0)
           System.Console.WriteLine("2");
  else if (points[0] < 0 && points[1] < 0)
          System.Console.WriteLine("3");
  else 
          System.Console.WriteLine("4");