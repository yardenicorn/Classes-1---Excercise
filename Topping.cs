using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Topping
{
    public string Name { get; private set; }
    public bool IsVegan { get; private set; }
    public int Price { get; private set; }

    public Topping(string name, int price, bool isVegan)
    {
        Name = name;
        Price = price;
        IsVegan = isVegan;
    }
}