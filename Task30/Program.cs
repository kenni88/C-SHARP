// Напишите программу,которая выводит массив из 8 элементов,
//заполненнный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

int[] array = new int [8];

Array(array);
WriteArray(array);

void Array(int[] arr)
{
  Random rand = new Random();
  for (int i=0; i<arr.Length; i++)
  {
    arr[i]=rand.Next(0,2);
  }  
}

void WriteArray(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
}