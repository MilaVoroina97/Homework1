// Функция, которая находит максимум из 9 чисел

int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2  > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 33;
int a2 = 356;
int a3 = 59;
int a4 = 55343;
int a5 = 12;
int a6 = 321;
int a7 = 2828;
int a8 = 232;
int a9 = 2478;
//int max1 = Max(a1,a2,a3);
//int max2 = Max(a4,a5,a6);
//int max3 = Max(a7,a8,a9);
int max = Max( 
    Max(a1,a2,a3),
    Max(a4,a5,a6),
    Max(a7,a8,a9));

Console.WriteLine(max);
