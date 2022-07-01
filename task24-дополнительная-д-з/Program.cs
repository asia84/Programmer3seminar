Console.WriteLine($"Введите значение K, чтобы найти К-ое неотрицательное целое круглое число : ");

int k = Convert.ToInt32(Console.ReadLine());
int i;                   //инициализация переменной, в которой будет находиться остаток от деления
int n = k - 1;          //порядковый номер 
int circle = 0,j = 1;  //значения круглых чисел   /   шаг
while (n > 0)
{
    i = n % 2;
    n = n / 2;
    circle = i*5*j+circle;
    j=j*10;
}
    Console.WriteLine (circle);