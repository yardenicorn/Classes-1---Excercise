using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pizza
{
    public int basePrice { get; private set; } = 20;
    public List<Topping> Toppings { get; private set; }
    public bool isVegan { get; private set; }

    public Pizza(bool isVegan)
    {
        this.isVegan = isVegan;
    }

    List<Topping> ToppingsMenu = new List<Topping>
            {
            new Topping("extra cheese", 1, false),
            new Topping("green olives", 1, true),
            new Topping("black olives", 1, true),
            new Topping("mushrooms", 1, true),
            new Topping("onions", 1, true),
            new Topping("garlic", 1, true),
            new Topping("corn", 1, true),
            new Topping("pepperoni", 5, false),
            new Topping("tuna", 5, false),
            new Topping("ham", 5, false),
            new Topping("goomba sauce", 3, true),
            new Topping("soy cheese", 3, true),
            new Topping("vegan meat", 3, true),
            };

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

    public void CreatePizza(List<Topping> userToppings)
    {

    }

    public void PizzaPrice()
    {

    }
}