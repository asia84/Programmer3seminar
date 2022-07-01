/*22.1/Напишите программу которая принимает на вход чиcло N,  и выдает таблицу квадратов от 1 до N
5->1,4,9,16,25
2-> 1,4*/
int n; 
n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine (i * i);
}
