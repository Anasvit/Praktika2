// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Persistence(39));  
        Console.WriteLine(Persistence(9));   
        Console.WriteLine(Persistence(999)); 
    }

    static int Persistence(int num)
    {
        int count = 0;

        while (num >= 10)
        {
            int product = 1;
            foreach (char digit in num.ToString())
            {
                product *= (digit - '0'); 
            }
            num = product; 
            count++; 
        }

        return count;
    }
}
