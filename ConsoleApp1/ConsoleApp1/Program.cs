using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program 
{
    static void Main()
    {
        Money x = new Money(100, 5);
        x.Show();
        Console.WriteLine(x.Summa(300));
        Console.WriteLine(x.Product_count(49));
        Console.WriteLine(x.Denomination);

            
    }









}