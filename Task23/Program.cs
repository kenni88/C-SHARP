// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

TableCube(number);

void TableCube (int num)
{
    int i = 1;
    while (i <= num)
    {
      Console.WriteLine($"{i}->{i*i*i}");
      i++;  
    }

}
