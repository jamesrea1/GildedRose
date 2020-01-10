using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    public class Legendary : Item
    {
        public Legendary(string name, int sellIn, int quality)
                : base(name, sellIn, quality)
        {

        }

        public override void UpdateSellIn() { }
        public override void UpdateQuality() { }


    }
}
