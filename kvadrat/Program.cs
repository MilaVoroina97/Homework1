// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
Console.WriteLine(" Введите число N :");
int n = Convert.ToInt32( Console.ReadLine());
int[] kvadrat = new int[n];
int index = 1;
while (index <= n)
{
    kvadrat[index - 1] = (index* index);
    index++;
}
var str = string.Join(" ",kvadrat);
Console.WriteLine(str);