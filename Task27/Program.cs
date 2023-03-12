// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());

int sumnumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел ={sumnumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    while (num>0)
    {
        sum += num % 10;
        num = num /10;
    }
    return sum;
}
