string MessageDiapasone(int chetvert)
{
    if (chetvert>=0 && chetvert<=4)
    {
        if (chetvert == 1) return "x>0, y>0";
        else if (chetvert == 2) return "x<0, y>0";
        else if (chetvert == 3) return "x<0, y<0";
        else if (chetvert == 4) return "x>0, y<0";
        else if (chetvert == 0) return "";
        else return "Неведанная ошибка";
    }
    else if (chetvert == 0) return "";
    return "Вы ввели не номер четверти!";
}

int chetvert = 5;
while (chetvert!=0)
{
    try 
        {
        Console.Write("Введите номер четверти (от 1 до 4, или 0 - выход): ");
        chetvert = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(MessageDiapasone(chetvert));
        }
    catch 
        {
        Console.WriteLine("Вы ввели не номер четверти!");
        }
}
