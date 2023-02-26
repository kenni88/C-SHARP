//Напишите программу, которая на вход
//принимает одно число (N), а на выходе
//показывает все целые числа в промежутке от -N до N

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    for (int i = -number; i <= number; i++)
    {
        Console.Write(i + " ");
    }
}
else
    {
        Console.Write("Должно быть положительное целое число");
}