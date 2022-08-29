// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

// int[]arr = {5,6,7,99,11,100,55,4};
// //foreach (int i in arr) Console.Write($"{i} ,");
// for(int i = 0; i < arr.Length;i++)
// {
//      Console.Write($"{arr[i]} ,");
    
// }
//  Console.WriteLine();
//  Console.WriteLine("I need number with index 9. This is : " + arr[3]);

void task(int[] array)
                {
                    var rand = new Random();
                    for (int i= 0; i<array.Length; i++)
                    {
                        array[i] = rand.Next(101);
                        Console.Write($"{array[i]}, ");
                    }

                    int max = array[0];
                    int max_i = 0;
                    for (int i= 0; i<array.Length; i++)
                    {
                        if (array[i]>max) 
                        {
                            max = array[i];
                            max_i = i;
                        }

                    }

                    Console.WriteLine();
                    Console.WriteLine($"{max}, {max_i}");
                }

            
            Console.WriteLine("Введите размерность массива N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            task(array);



//Console.WriteLine("Введите целое число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int [] numbers = new int[n];
//for(int i = 0; i < n; i++)
    //{
        //numbers[i] = new Random().Next(1,100);
        //Console.Write($"{numbers[i]}, ");
    //}
