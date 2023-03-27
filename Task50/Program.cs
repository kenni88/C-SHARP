// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого элемента в массиве нет

 Console.WriteLine("Введите индекс строки:");
 int indexA = Convert.ToInt32(Console.ReadLine())-1;
 Console.WriteLine("Введите индекс столбца:");
 int indexB = Convert.ToInt32(Console.ReadLine())-1;

 int[,] array = CreateMatrixRndInt(5, 6, 10, 99);
 PrintMatrix(array);
 SearchElement(array, indexA, indexB);

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
         Console.Write($" {matrix[i,j]} ");
     }
     Console.WriteLine("|");
     }
 }

 int[,] SearchElement(int[,] matrix, int indA, int indB)
 {
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
             if (indA > matrix.GetLength(0)-1| indB > matrix.GetLength(1)-1)
            {
                 Console.WriteLine("Элемент не существует");
             }
             else
             {
                 Console.WriteLine("Значение элемента массива = {0}", matrix[indA,indB]);
                 Console.ReadLine();
             }
 
         }
     }
     return matrix;
 }

// Console.Write("Введите строку: ");
// int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите столбец: ");
// int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
// int n = 5; 
// int m = 7; 
// Random random = new Random();
// int[,] arr = new int[n, m];
// Console.WriteLine("Исходный массив: ");
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
// {
//     arr[i, j] = random.Next(10, 99);
// Console.Write("{0} ", arr[i, j]);
// }
// Console.WriteLine();
// }
//     if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
// {
// Console.WriteLine("Элемент не существует  ");
// }
//     else
// {
//     Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
// }
// Console.ReadLine();
