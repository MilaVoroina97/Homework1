// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    Console.WriteLine("Наибольшее число из трех чисел : " + a);
}
else
{
    if (b > a && b > c)
    {
        Console.WriteLine("Наибольшее число из трех чисел : " + b);
    }
    else
    {
        Console.WriteLine("Наибольшее число из трех чисел : " + c);
    }
}

