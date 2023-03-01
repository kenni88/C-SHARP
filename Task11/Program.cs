



int number = new Random().Next(100,1000);
int firstDigit=number/100;
int secondDigit=number%10;
Console.WriteLine($"Случайное число отрезка {number}->{firstDigit}{secondDigit}");