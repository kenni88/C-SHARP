// Задайте две матрицы. Напишите программу, которая будет 
//находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] arrayfirst = CreateMatrixRndInt(3, 4, 1, 10);
int[,] arraysecond = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(arrayfirst);
Console.WriteLine();
PrintMatrix(arraysecond);
//int[,] arraynew = new int [];

MultiplyMatrix(arrayfirst, arraysecond, arraynew);


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

void MultiplyMatrix(int[,] firstmatrix, int[,] secondmatrix, int[,]resultmatrix)
{
    for (int i = 0; i < resultmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultmatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k=0;k<firstmatrix.GetLength(1);k++)
            {
                sum+=firstmatrix[i,k]*secondmatrix[k,j];
            }
            resultmatrix[i,j]=sum;
            Console.WriteLine($"Произведение двух матриц:{sum}");
        }
    }
}