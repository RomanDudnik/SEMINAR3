/*
           | y
           |
    II     |      I
           |

________________________x

           |
    III    |      IV
           |
           |


I (x > 0; y > 0)
II (x < 0, y > 0)
III (x < 0, y < 0)
IV (x > 0, y < 0)
*/

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
        Console.WriteLine("this point on 4st quater");
    else Console.WriteLine("its imposible at this task!");
}

Console.WriteLine("Input your X number: ");
int xCoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input your Y number: ");
int yCoord = Convert.ToInt32(Console.ReadLine());

Funkt(xCoord, yCoord);
*/

//Напишите программу, которая по заданному номеру четверти
//показывает диапазон возможных координат точек в этой четверти (x, y).

/*
void PossibleValue(int n)
{
    if (n == 1)
        Console.WriteLine("1st quater X > 0, Y > 0");
    else if (n == 2)
        Console.WriteLine("2st quater X < 0, Y > 0");
    else if (n == 3)
        Console.WriteLine("3st quater X < 0, Y < 0");
    else Console.WriteLine("4th quater X > 0, Y < 0");
}

Console.WriteLine("input number of quater: ");
int numQuater = Convert.ToInt32(Console.ReadLine());

if (numQuater >= 1 && numQuater <= 4)
    PossibleValue(numQuater);
else Console.WriteLine ("its not number of quater!");
*/

//Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 2D пространстве.
//A(x1, y1); B(x2, y2)
//Math.Sqrt(num);

//Вариант с методом №1
/*
double LongLine(int x1, int y1, int x2, int y2)
{
    double lenghtAB = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));   //функция корень квадратный - Math.Sqrt(...)
    return lenghtAB;
}
*/
//Вариант с методом №2
/*
double LongLine(int x1, int y1, int x2, int y2)
{
    int x = x2 - x1;
    int y = y2 - y1;
    double lenghtAB = Math.Round(Math.Sqrt(x*x + y*y), 3);   //функция корень квадратный - Math.Sqrt(...), функция Math.Round(..., 3) - для сокращения кол-ва цифр остатка
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
/*
void Qurd(int num)
{
    int current = 1;
    while (current <= num)
    {
        int res = current * current;
        Console.Write($"{res} ");
        current ++;
    }
    Console.WriteLine("\b.");   //убирает символ в выводе в конце, ("\b\b.") - убирает два символа в конце и т.д.
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1)
{
    Console.Write($"{number} -> ");
    Qurd(number);
}
else Console.WriteLine("imposible number!");
*/