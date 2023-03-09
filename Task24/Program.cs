// Напишите программу,которая принимает на вход число (А)
// и выдает сумму чисел от 1 до А.

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int sumnumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number}={sumnumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i= 1; i<=num; i++)
    {
        sum += i;
    }
    return sum;
}