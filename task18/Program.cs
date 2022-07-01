/*18/Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти(x,y)*/

int n;

n = Convert.ToInt32(Console.ReadLine());
if(n > 0 && n<5)
{
if(n ==1)
{
    Console.WriteLine("x = (0, +~)");
    Console.WriteLine("y = (0, +~)");
}   
if( n == 2)
{ 
    Console.WriteLine("x = (-~, 0 )");
    Console.WriteLine("y = (0, +~)");
}
if( n == 3)
{
    Console.WriteLine("x = (-~, 0 )");
    Console.WriteLine("y = (-~, 0 )");
}
if( n ==  4)
{ 
    Console.WriteLine("x = (0, +~)");
    Console.WriteLine("y = (-~, 0 )");
}
}
else
{
    Console.WriteLine("Такой четверти нет!!! Ты врун!");
}