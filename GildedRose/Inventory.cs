using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    class Inventory
    {
        public Inventory()
        {
            Items = new List<Item>();
        }

        public List<Item> Items
        {
            get;
        }

        public void AddItem(string name, int sellIn, int quality)
        {
            switch (name)
            {
                case "Aged Brie":
                    Items.Add(new Cheese(name, sellIn, quality));
                    break;
                case "Backstage Passes":
                    Items.Add(new BackstagePasses(name, sellIn, quality));
                    break;
                case "Sulfuras":
                    Items.Add(new Legendary(name, sellIn, quality));
                    break;
                case "Normal Item":
                    Items.Add(new Item(name, sellIn, quality));
                    break;
                case "INVALID ITEM":
                    Items.Add(new Item(name, sellIn, quality));
                    break;
                case "Conjured":
                    Items.Add(new Conjured(name, sellIn, quality));
                    break;
            }
        }

        public void Update()
        {
            foreach(Item item in Items)
            {
                item.UpdateSellIn();
                item.UpdateQuality();
            }
        }
    }
}
