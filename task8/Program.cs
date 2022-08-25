//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
string result(int N)
    {int i = 1;
    string f = "";
    while (i <= N)
    {
        f + (i*i + " ");
        i++;
    }
    return f;
    }
Console.WriteLine("Введите целое число N для вычисления квадратов: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(result N);

//Задача 22: Напишите программу, которая
//    принимает на вход число (N) и выдаёт
//    таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

void SquareTableN()
{
    Console.Write("Введите число ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] answer = new int[N];
    if (N > 0)
    {
        for (int i = 1; i < (N + 1); i++)
        {
            answer[i - 1] = (i * i);
        }
    }
    else
        {
            Console.Write("Надо было вводить положительные числа");
        }
    var str = string.Join(" ", answer);
    Console.WriteLine(str);
}

try
{
    SquareTableN();
}
catch
{
    Console.Write("Надо было вводить числа");
}
