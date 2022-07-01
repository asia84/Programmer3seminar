/*21/ Напишите программу, которая принимает на вход координаты двух точек 
и  находит расстояние м/у ними в 2d пространстве(x -0 - y)
A(3,6);B(2,1)->5,09
A(7,-5);B(1,-1)->7,21*/


double x, y, x1, y1, distance;
x = Convert.ToDouble(Console.ReadLine());
y = Convert.ToDouble(Console.ReadLine());
x1 = Convert.ToDouble(Console.ReadLine());
y1= Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt((x - x1) * (x - x1) + (y - y1 )* (y - y1)); 
Console.WriteLine(distance);                                     


/*Console.ReadLine()
/*double x, y, x1, y1, len;
x = Convert.ToDouble(Console.ReadLine());
y = Convert.ToDouble(Console.ReadLine());
x1 = Convert.ToDouble(Console.ReadLine());
y1 = Convert.ToDouble(Console.ReadLine()); 

len = Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1));             /*рассчет расстояния (квадрат). Math - это библиотека и Sqrt 
Console.WriteLine(len);*/                                               /*- это функция, отвечающая за квадраты(квадратный корень числа)*/

