// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа

int number = new Random(). Next(10,100);
Console.WriteLine(number);
string y = number.ToString();
if (y[0] > y[1])
{
    Console.WriteLine(y[0]);
}
else
{
    if (y[0]< y[1])
    {
        Console.WriteLine(y[1]);
    }
   
}