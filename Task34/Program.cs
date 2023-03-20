// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] array = CreateArrayRndInt(5,100,999);
PrintArray(array);
int countEvenNumber=CountEvenNumber(array);
Console.WriteLine($"Количество четных чисел в массиве равно {countEvenNumber}");

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

void PrintArray(int[] arrayValue)
{
    for (int i = 0; i < arrayValue.Length; i++)
    {
        if (i!=arrayValue.Length-1) 
        {
            Console.Write($"{arrayValue[i]} ");
        }
        else Console.Write($"{arrayValue[i]}\n");
    }
}

int CountEvenNumber(int[] arrayValue)
{
    int count=0;
    for (int i = 0; i < arrayValue.Length; i++)
    {
        if (array[i]%2==0) count++;
    }
    return count;
}
