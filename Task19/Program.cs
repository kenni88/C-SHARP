// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int digit1 = number/1000;
int digit2 = number%100;

if (number < 0 ) number *= -1;
if (number > 9999 && number < 100000)
{
     if (digit1 == digit2)
     {
        Console.WriteLine($"{number} ->да");
        }
        else
        {
         Console.WriteLine($"{number} ->нет");    
        }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
