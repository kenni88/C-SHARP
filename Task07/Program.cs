//Напишите программу, которая принимает на вход
//трехзначное число и на выходе показывает
//последнюю цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0 ) number *= -1;
if (number > 99 && number < 1000)
{
    int result = number % 10;
    Console.Write(result);
}
else
{
    Console.Write("Нужно ввести трехзначное число");
}