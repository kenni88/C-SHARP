// Напишите программу, которая принимает на вход число (N) 
// и выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1,4

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

TableSquare(number);

void TableSquare (int num)
{
    int i = 1;
    while (i <= num)
    {
      Console.WriteLine($"{i} {i*i}");
      i++;  
    }

}


