using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class PizzaSoftware
{
    public static void Main()
    {
        Console.WriteLine("Hello and Welcome to The Unicorn Pizza!");
        Console.WriteLine("Would you like: \n 1. Vegan Pizza \n 2. Non Vegan Pizza \n Please enter valid numbers only");

        bool IsNumeric = Int32.TryParse(Console.ReadLine(), out int userInput);

        while (!IsNumeric || (userInput != 1 && userInput != 2))
        {
            Console.WriteLine("Please enter valid numbers only");
            IsNumeric = Int32.TryParse(Console.ReadLine(), out userInput);
        }

        bool isVegan = (userInput == 1) ? true : false;
        Pizza newPizza = new Pizza(isVegan);
        Console.WriteLine("OK! These are your options for toppings! \n Please enter the numbers of toppings you would like to add to your pizza. when your'e done - write 0");
        newPizza.PrintToppingMenu();

        

        Console.ReadKey();
    }
}