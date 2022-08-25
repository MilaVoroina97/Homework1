//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
//номер четверти плоскости, в которой находится эта точка.

int GetNum4()
{    Console.WriteLine("Введите координату х : ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату у ");
    int y = Convert.ToInt32(Console.ReadLine());
    int res;
    if (x > 0 && y > 0)  res = 1; //когда одна инструкция можно обходиться без скобок
    else if (x < 0 && y > 0)  res = 2;
    else if (x < 0 && y < 0)  res = 3;
    else if (x > 0 && y < 0)  res = 4;
    else res = 0;
    return(res);
}

try // блок в котором программа попытается сделать функцию прописанную в теле функции, если не получится то,
// перейдет в блок catch
{
    Console.WriteLine(GetNum4());
}
catch
{
    Console.WriteLine("Надо было вводить именно числа, и именно целые!");  
}