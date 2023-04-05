// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);



 int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}");
        }
        Console.WriteLine("|");
    }
}

int SumRows(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1;j< array.GetLength(1);j++)
    {
        sum+=array[i,j];
    }
    return sum;
}

int minSum = 0;
int sum = SumRows(array2d,0);
for (int i = 1;i<array2d.GetLength(0);i++)
{
    if (sum>SumRows(array2d,i))
    {
        sum = SumRows(array2d,i);
        minSum = i;
    }
}
Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");