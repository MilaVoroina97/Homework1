// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли наименьшее число кратным наибольшему. 
//Если наибоьшее не кратно наименьшему, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

void MaxMin()
{
    Console.WriteLine("Введите первое число: ");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int y = int.Parse(Console.ReadLine());
    int max = 0;
    int min = 0;
    if (x > y)
    {
        max = x;
        Console.WriteLine("Максимальное число из двух:" + max);
    }
    else
    {
        max = y;
        Console.WriteLine("Максимальное число из двух:" + max);
    }
    if (x < y)
    {
        min = x;
        Console.WriteLine("Минмальное число из двух:" + min);
    }    
    else
    {
        min = y;
        Console.WriteLine("Минмальное число из двух:" + min);
    }
    if (max % min ==0)
    {
        Console.WriteLine("Числа делятся без остатка");
    }
    else
    {
        Console.WriteLine("Остаток от деления равен:" + max % min);
    }
}
MaxMin();

