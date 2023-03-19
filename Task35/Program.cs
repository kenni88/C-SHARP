// Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива,которые лежат в отрезке[10,99].

int[] array = CreateArrayRndInt (12, -150, 150);
PrintArray(array);
int arraySearch = ArraySearch(array);
Console.WriteLine($"Количество двузначных элементов в массиве равно {arraySearch}");

int ArraySearch(int[] arrayValue)
{
    int count=0;
    for (int i = 0; i < arrayValue.Length; i++)
    {
        if (array[i]>=10 && array[i]<=99) count++;
    }
    return count;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
       arr[i] = rand.Next(min, max+1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}