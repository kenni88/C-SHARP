// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array=new int[8];

FillArray(array);
PrintArray(array);

void FillArray(int[] collection)
{
    
    Random rand = new Random();
    for(int i=0;i<array.Length;i++)
    {
     array[i]=rand.Next(1,33);
    }
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for(int i=0;i<array.Length;i++)
    {
        Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length-1]}");
    System.Console.WriteLine("]");
}
