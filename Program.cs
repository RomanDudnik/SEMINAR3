//Напишите программу, которая принимает на вход две координаты точки (x, y),
//причем x и y не равны нулю 0 и выдает номер четверти плоскости, в которй находится эта точка.
/*
void Funkt( int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("this point on 1st quater");
    else if (x < 0 && y > 0)
        Console.WriteLine("this point on 2st quater");
    else if (x < 0 && y < 0)
        Console.WriteLine("this point on 3st quater");
    else if (x > 0 && y < 0)
        Console.WriteLine("this point on 2st quater");
    else Console.WriteLine("its imposible at this task!");
}

Console.WriteLine("Input your X number: ");
int xCoord = Conver.ToInt32(Console.ReadLine());

Console.WriteLine("Input your Y number: ");
int yCoord = Conver.ToInt32(Console.ReadLine());

Funkt(xCoord, yCoord);
*/

//Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N. 5 -> 1, 4, 9, 16, 25. 2 -> 1,4
/*
void PssibleValue(int n)
{
    if (n == 1)
        Console.WriteLine("1st quater X > 0, Y > 0");
    else if (n ==2)
        Console.WriteLine("2st quater X < 0, Y > 0");
    else if (n ==2)
        Console.WriteLine("3st quater X < 0, Y < 0");
    else Console.WriteLine("4st quater X > 0, Y < 0");
}

Console.WriteLine("input number of quater: ");
int numQuater = Convert.ToInt32(Console.ReadLine());

if (numQuater => 1 && numQater)
    PossibleValue(numQater);
else Console.WriteLine ("its not number of quater!");
*/
//Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 2D пространстве.
//A(x1, y1); B(x2, y2)
//Math.Sqrt(num);

/*
double LongLine(int x1, int y1, int x2, int y2)
{
    int x = x2 - x1;
    int y = y2 - y1;
    double lenghtAB = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
    return lenghtAB;
}

Console.WriteLine("input X coordinat of A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input Y coordinat of A: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input X coordinat of B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input Y coordinat of B: ");
int yB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine(xA, yA, xB, yB);

Console.WriteLine($"Distanse AB is {dist}");
*/

//Напишите программу, которая принимает на вход число (N) и 
//выдает таблицу квадратов чисел от 1 до N
//5 -> 1, 4, 9, 16, 25
//2 -> 1, 4

void Qurd(int num)
{
    int current = 1;
    while (current <= num)
    {
        int res = current * current;
        Console.Write($"{res} ");
        current ++;
    }
    //Console.WriteLine("\b\b.");   //убирает два символа
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1)
{
    Console.Write($"{number} -> ");
    Qurd(number);
}
else Console.WriteLine("imposible number!");
