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



internal class Program
{
    static void Main(string[] args)
    {
        
     string GetNum4()
        {
            string res = "";
            Console.Write("QUATER Nr. ");
            int x = int.Parse(Console.ReadLine()); 

            if ( x==1 )           res = "x>0 && y>0";
            else if ( x==2 )      res = "x<0 && y>0";
            else if ( x==3 )      res = "x<0 && y<0";
            else if ( x==4 )      res = "x>0 && y<0";
            else                  res = "Quater nr must be within 1-4";           
            return res;
        }
        try
            {
            Console.WriteLine(GetNum4());
            }
        catch
            {
            Console.WriteLine("Must be integers");    
            }
    }
}
