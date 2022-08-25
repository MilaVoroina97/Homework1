   
 double distance(int xa,int ya,int xb, int yb)
 {
     return Math.Sqrt(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2));  
 }
   try 
   {
    Console.WriteLine("Введите координату х в точке а: ");
    int xa = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату у в точке а");
    int ya = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату х в точке b: ");
    int xb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату у в точке b");
    int yb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine (distance(xa,ya,xb,yb));
   }
   catch
   {
    Console.WriteLine (" Вы ввели неверные координаты ");
   }
   
  


double Res () 
     {
       Console.WriteLine("Введите координаты точки A (x;у) ");
        int Ax=Convert.ToInt32(Console.ReadLine());
        int Ay=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты точки B (x;у) ");
        int Bx=Convert.ToInt32(Console.ReadLine());
        int By=Convert.ToInt32(Console.ReadLine());

        int x =Ax-Bx;
        int y = Ay-By;
        double S = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));   
        return S;
     }
try
{
    
     Console.WriteLine(Res());
            
}
catch
{
    Console.WriteLine("введите цифры");
}        
     
