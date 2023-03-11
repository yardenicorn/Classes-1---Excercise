using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PizzaSoftware
{
    public void Main()
    {
        Console.WriteLine("Hello and Welcome to The Unicorn Pizza!");
        Console.WriteLine("Would you like:" +
            "1. Vegan Pizza" +
            "2. Non Vegan Pizza" +
            "Please enter valid numbers only");

        bool IsNumeric = Int32.TryParse(Console.ReadLine(), out int PizzaType);

        while (IsNumeric)
        {
            Console.WriteLine("Please enter valid numbers only");
            IsNumeric = Int32.TryParse(Console.ReadLine(), out PizzaType);
        }

        Console.ReadKey();
    }
}
