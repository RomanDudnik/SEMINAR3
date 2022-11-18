//Напишите программу, которая принимает на вход две координаты точки (x, y),
//причем x и y не равны нулю 0 и выдает номер четверти плоскости, в которй находится эта точка.

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

//Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N. 5 -> 1, 4, 9, 16, 25. 2 -> 1,4

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


