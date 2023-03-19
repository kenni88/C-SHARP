﻿// Задайте массив. Напишите программу, которая определяет,
//присутствует ли заданное число в массиве.

Console.Write("Введите размер массива");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];

FillArray(array);
PrintArray(array);
Console.Write("Введите число,которое будем искать в массиве:");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(ArraySearch(array,number) ? "Да" : "Нет");

void FillArray (int[] arrayValue)
{
Random rnd = new Random();
for (int i = 0; i < arrayValue.Length; i++)
{
    arrayValue[i]=rnd.Next(-10,10);
}
}

bool ArraySearch(int[] arrayValue, int numberValue)
{
    for (int i = 0; i < arrayValue.Length; i++)
    {
        if (array[i] == numberValue) return true;
    }
    return false;
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
