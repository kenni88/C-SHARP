// Задача 42: Напишите программу, которая будет преобразовывать
//десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string DecimalToBinary(int n)
{
    string result=string.Empty;
    while(n>0)
    {
        result=result+n%2;
        n=n/2;
    }
    return result;
}

Console.WriteLine(DecimalToBinary);