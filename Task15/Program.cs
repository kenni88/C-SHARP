//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number>0 && number <=7)
{
    if (number>5)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
       Console.WriteLine("Рабочий день"); 
    }
} 
else
{
Console.WriteLine("Такого дня недели не существует");
}