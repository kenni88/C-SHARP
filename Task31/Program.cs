﻿// Задайте массив из 12 элементов,заполненный случайными числами
//из промежутка [-9,9]. Найдите сумму отрицательных и положительных 
//элементов массива.

int [] array = CreateArrayRndInt(12,-9,9);
PrintArray(array);

int sumNegative=GetSumNegativeElem(array);
int sumPositive=GetSumPositiveElem(array);
Console.WriteLine($"Сумма положительных элементов={sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов={sumNegative}");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
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

int GetSumNegativeElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
     if (arr[i]<0) sum+=arr[i];   
    }
    return sum;
}

int GetSumPositiveElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
     if (arr[i]>0) sum+=arr[i];   
    }
    return sum;
} 