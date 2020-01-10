using System;
using System.Collections.Generic;

namespace GildedRose
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inv = new Inventory();
            inv.AddItem("Aged Brie", 1, 1);
            inv.AddItem("Backstage Passes", -1, 2);
            inv.AddItem("Backstage Passes", 9, 2);
            inv.AddItem("Sulfuras", 2, 2);
            inv.AddItem("Normal Item", -1, 55);
            inv.AddItem("Normal Item", 2, 2);
            inv.AddItem("INVALID ITEM", 2, 2);
            inv.AddItem("Conjured", 2, 2);
            inv.AddItem("Conjured", -1, 5);
            
            DisplayInputData(inv);

            inv.Update();

            Console.WriteLine("---");
            DisplayOutput(inv);

            Console.ReadLine();
        }

        static void DisplayInputData(Inventory inv)
        {
            foreach (Item item in inv.Items)
            {
                Console.WriteLine($"{item.Name}\t{item.SellIn} {item.Quality}");
            }
        }

        static void DisplayOutput(Inventory inv)
        {
            foreach (Item item in inv.Items)
            {
                Console.WriteLine(item.ToString());
            }
        }


    }
}
