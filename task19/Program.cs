/*19/Напишите программу, которая принимает на вход пятизначное число, и проверяет является ди оно палиндромом:
14212-> нет
23432-> да
12821-> нет
*/


Console.WriteLine("Введите пятизначное число, чтобы проверить является ли оно палиндромом: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number > 9999) && (number < 100000))
{
    // n сохраняет заданное целое число
int n = number;
    // revers хранит обратную сторону заданного целого числа
int revers = 0;
    // r - для хранения выделенной из n последней цифры
int r = 0;
while (n > 0)
    {
        // это сохранит последнюю цифру n в переменной r
        // например, если n равно 21531, то `r` будет равно 1
        r = n % 10;
         // добавляем r к revers вместо себя
        // например, если revers = 35 и r = 1, то новый revers будет 351
        revers = revers * 10 + r;
         // удалить последнюю цифру из n
        // например, если n равно 21531, то новое n будет 2153
        n = n / 10;
    }
    if ((number - revers) == 0) 
    { 
        Console.WriteLine("Это число является палиндромом.");
    }
    else 
    {
        Console.WriteLine("Это число не является палиндромом.");
    }
}
else
{
    Console.WriteLine("Это число не пятизначное.");
}































