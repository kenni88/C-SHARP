﻿// Напишите программу замена элементов массива:
//положительные элементы замените на соответствующие
//отрицательные и наоборот.
//[-4,-8,8,2]->[4,8,-8,-2]

Console.Write("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] array =new int[size];

FillArray(array);
PrintArray(array);
EditArray(array);
PrintArray(array);

void FillArray (int[] arrayValue)
{
Random rnd = new Random();
for (int i = 0; i < arrayValue.Length; i++)
{
    arrayValue[i]=rnd.Next(-10,10);
}
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

void EditArray(int[] arrayValue)
{
    for (int i = 0; i < arrayValue.Length; i++)
    {
        array[i]*=-1;
    }
}