// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.Write("Введите количество элементов массива:");
int num=Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[num];

FillArray(num);
Console.Write($"\nРазница между максимальным и минимальным элементом массива:{DiffBetweenMaxMin(randomArray):F2}");

void FillArray(int num)
{
    Random rand = new Random();
    for (int i=0; i<num;i++)
    {
        randomArray[i]=rand.NextDouble();
        Console.Write($"{randomArray[i]:F2}  ");
    }
}

double DiffBetweenMaxMin(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i=1;
    while (i<randomArray.Length)
    {
        if (max<randomArray[i]) max = randomArray[i];
        if (min>randomArray[i]) min = randomArray[i];
        i+=1;
    }
return max-min;
}