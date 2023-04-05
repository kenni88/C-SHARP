//Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int numberN = Convert.ToInt32(Console.ReadLine());


void SumNumbers (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    SumNumbers(numberM, numberN, sum);
}

SumNumbers(numberM, numberN, 0);