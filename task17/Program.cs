/*17/Напишите программу, которая на вход принимает координаты точки(x,y)
причем x неравно 0 и y не равен нулю и выдает номер четверти плоскости, в которой находится эта точка*/
int x, y;
x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());
if( x > 0 && y > 0)
    Console.WriteLine("I четверть");
if( x < 0 && y > 0)
    Console.WriteLine("II четверть");
if( x < 0 && y < 0)
    Console.WriteLine("III четверть");
if( x > 0 && y < 0)
    Console.WriteLine("IV четверть");

