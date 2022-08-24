// Доп. задание, которое было дано на семинаре. Вывести второе число слева направо в любом вводимом целом числе 

// 1 вариант 

//Console.WriteLine("Введите целое  число: ");
//string x = Console.ReadLine();

//var result = x.Skip(1).Take(1).FirstOrDefault();
//Console.Write(result); // => 1


// 2 вариант

Console.WriteLine("Введите целое  число: ");
string x = Console.ReadLine(); 
int y = int.Parse(x);
string a = x.Substring(1,1); //диапозон обрезки индекс начала обрезки и длину вырезаемой части строки.
if (y > 9) Console.WriteLine(a);
else Console.WriteLine("enter number, which is more than 10");