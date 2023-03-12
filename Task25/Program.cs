// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите первое число:");
int powerBase = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int exponent = Convert.ToInt32(Console.ReadLine());

if (ValidateExponent(exponent))
{
    System.Console.WriteLine($"Число{powerBase} в степени{exponent} равно {Power(powerBase,exponent)}");
}

int Power(int powBas, int exp)
{
    int power = 1;
    for (int i =0; i<exp; i++)
    {
        power *= powBas;
    }
    return power;
}

bool ValidateExponent(int exp)
{
    if (exp<0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}