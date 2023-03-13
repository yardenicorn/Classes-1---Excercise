using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pizza
{
    // what is the convention for constant value in classes?
    public const int basePrice = 20;
    public List<Topping> Toppings { get; private set; } = new List<Topping>();
    public bool isVegan { get; private set; }

    public Pizza(bool isVegan)
    {
        this.isVegan = isVegan;
    }

    // needs to be a list of constant toppings, how do I do this?
    List<Topping> ToppingsMenu = new List<Topping>
    {
         new Topping("extra cheese", 5, false),
         new Topping("green olives", 3, true),
         new Topping("black olives", 3, true),
         new Topping("mushrooms", 3, true),
         new Topping("onions", 3, true),
         new Topping("garlic", 3, true),
         new Topping("corn", 3, true),
         new Topping("pepperoni", 5, false),
         new Topping("tuna", 5, false),
         new Topping("ham", 5, false),
         new Topping("goomba sauce", 5, true),
         new Topping("soy cheese", 10, true),
         new Topping("vegan meat", 10, true),
    };

    // prints the optional toppings for the user to choose, according to the pizza he had chosen
    public void PrintToppingMenu()
    {
        for (int i = 0; i < ToppingsMenu.Count; i++)
        {
            if (isVegan && !ToppingsMenu[i].IsVegan)
            {
                continue;
            }
            Console.WriteLine($"{i+1} {ToppingsMenu[i].Name}, Price: {ToppingsMenu[i].Price}");
        }
    }

    // adding the toppings the user chose on his pizza.
    // should I use another name for the function?
    public void CreatePizza()
    {
        int topping = UserInputToppingIndex();
        while (topping != 0)
        {
            Toppings.Add(ToppingsMenu[topping]);
            topping = UserInputToppingIndex();
        }
        YourOrder();
    }

    // checks if the user's input for topping is legit. if yes - it returns the topping.
    // should I use another name for the function?
    private int UserInputToppingIndex()
    {
        bool IsNumeric = Int32.TryParse(Console.ReadLine(), out int topping);

        // the loop needs to check that a number has been inserted, and not something else, or if the number is within the list's range or not a negative number.
        // the loop checks if the user's input is not legit.
        while (!IsNumeric || topping > ToppingsMenu.Count || topping < 0)
        {
            Console.WriteLine("Please enter valid numbers only");
            IsNumeric = Int32.TryParse(Console.ReadLine(), out topping);
        }
        return topping;
    }

    // calculate the pizza price according to the toppings that the user has chose
    public int PizzaPrice()
    {
        int pizzaPrice = basePrice;
        foreach (Topping t in Toppings)
        {
            pizzaPrice += t.Price;
        }
        return pizzaPrice;
    }

    // print to the screen the user's order with total price
    public void YourOrder()
    {
        Console.WriteLine("Your Order:");
        Console.WriteLine($"Base price for pizza: {basePrice}");
        foreach (Topping t in Toppings)
        {
            Console.WriteLine($"{t.Name}, Price: {t.Price}");
        }
        Console.WriteLine($"Total: {PizzaPrice()}");
        Console.WriteLine("Thank you for buying at The Unicorn Pizza!");
    }
}