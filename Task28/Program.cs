// Напишите программу, которая принимает на вход 
// число N и выдает произведение чисел от 1 до N.
// 4 -> 24
//5 -> 120

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int multiple = Factorial(number);
    Console.WriteLine($"Произведение чисел от 1 до {number}={multiple}");
}
else
{
    Console.WriteLine("Введите положительное число");
}
int Factorial(int num)
{
    int multi = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
             multi = multi * i;
        }
    }
    return multi;
}
