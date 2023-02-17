
static int Prompt(string m)
{
Console.WriteLine(m);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}


int x1 = Prompt("x1");
int y1 = Prompt("y1");

int x2 = Prompt("x2");
int y2 = Prompt("y2");

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine(d);


static void Task_01()
{
  Console.Clear();
  int userNumber = Prompt("Number of quarter");

  switch (userNumber)
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
}

static void Task_02()
{
  Console.Clear();
  int userNumber = Prompt("Input number");

  for (int i = 1; i <= userNumber; i++)
  {
    Console.WriteLine($"{i * i}\t");
  }
}