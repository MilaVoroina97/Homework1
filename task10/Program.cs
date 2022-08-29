// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

int[]arr = {5,6,7,99,11,100,55,4};
//foreach (int i in arr) Console.Write($"{i} ,");
for(int i = 0; i < arr.Length;i++)
{
     Console.Write($"{arr[i]} ,");
    
}
 Console.WriteLine();
 Console.WriteLine("I need number with index 9. This is : " + arr[3]);

