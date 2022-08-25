//void PrintNumbers (int num1,int num2)
//{
    //for (int i = num1; i <= num2; i++) Console.Write(i + ",");
    //Console.WriteLine();
//}

//PrintNumbers(2,8);
//PrintNumbers(1,7);
//PrintNumbers(5,9);


//void RandomNumber()
//{
    //int number = new Random(). Next(10,100);
    //Console.WriteLine(number);
    //string y = number.ToString();
    //if (y[0] > y[1])
    //{
        //Console.WriteLine(y[0]);
    //}

    //else
    //{
        //Console.WriteLine(y[1]);
    //}

//}


//RandomNumber();


// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

//void DeleteSecondNumber1()
//{
   // int number = new Random(). Next(100,1000);
    //Console.WriteLine(number);
    //string y = number.ToString();
    
    //for (int i = 0; i < y.Length; i++)
    //{
        //if (i != 1)
        //{
            //Console.Write(y[i]);
        //}
    //}
    //Console.WriteLine();
//}

//DeleteSecondNumber1();

void DeleteSecondNumber1()
{
    Console.WriteLine("Enter number: ");
    string number = Console.ReadLine();
    
    for (int i = 0; i < number.Length; i++)
    {
        if (i != 1)
        {
            Console.Write(number[i]);
        }
    }
    Console.WriteLine();
}

DeleteSecondNumber1();






