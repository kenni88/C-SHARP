﻿// Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.

int[]array = CreateArrayRndInt(5,1,10);
PrintArray(array);
int[] newArray=Multiple(array);
PrintArray(newArray);


int[] Multiple (int[] arr)
{
    int size = arr.Length/2;
    if (arr.Length%2!=0) size+=1;
    int[] newArr=new int[size];
    for (int i = 0; i < size; i++)
    {
        newArr[i]=arr[i]*arr[arr.Length-i-1];
    }
    if (arr.Length%2!=0) newArr[size-1]=arr[arr.Length/2];
    return newArr;
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