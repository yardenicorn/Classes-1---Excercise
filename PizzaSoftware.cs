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

        bool IsNumeric = Int32.TryParse(Console.ReadLine(), out int pizzaType);

        while (!IsNumeric || (pizzaType != 1 && pizzaType != 2))
        {
            Console.WriteLine("Please enter valid numbers only");
            IsNumeric = Int32.TryParse(Console.ReadLine(), out pizzaType);
        }

        bool isVegan = (pizzaType == 1) ? true : false;
        Pizza newPizza = new Pizza(isVegan);
        Console.WriteLine("OK! These are your options for toppings! \n Please enter the numbers of toppings you would like to add to your pizza. when your'e done - write 0");
        newPizza.PrintToppingMenu();
        newPizza.CreatePizza();
        Console.ReadKey();
    }
}