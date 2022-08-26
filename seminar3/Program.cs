// Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
try
{  
    Console.WriteLine(" Введите координату x: ");
    int x = Convert.ToInt32( Console.ReadLine());
    Console.WriteLine(" Введите координату y: ");
    int y = Convert.ToInt32( Console.ReadLine());
    int chetvert = 0;
    if ( x < 0 && y > 0)
    {
        Console.WriteLine(" Second");
    }
    else
    {
        if ( x > 0 && y > 0)
        {
            Console.WriteLine(" First");
        }
    }    
    if ( x < 0 && y < 0)
    {
        Console.WriteLine("Third");
    }

    else
    {
        if (x > 0 && y < 0)
        {
            Console.WriteLine("Fourth");
        }
    }
}
catch
{
    Console.WriteLine(" Нужно вводить целые числа");
}
