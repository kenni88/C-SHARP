// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] array = CreateArrayRndInt(7,-10,10);
PrintArray(array);
int sumUnevenPosition=SumUnevenPosition(array);
Console.WriteLine($"Сумма нечетных чисел в массиве равно {sumUnevenPosition}");

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

int SumUnevenPosition(int[] arrayValue)
{
    int sum = 0;
    for (int i = 1; i < arrayValue.Length; i+=2)
    {
       if (i%2==1) sum += arrayValue[i];
    }
    return sum;
}