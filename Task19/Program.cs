// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// (Строки и массивы использовать нельзя).

Console.WriteLine("Введите пятизначное число n:");
int n = Convert.ToInt32(Console.ReadLine());

int number = n;
int rev = 0;
int size = 0;

while(n > 0)
{
    size = n % 10;
    rev = rev * 10 + size;
    n = n /= 10;
}
if(number == rev)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

