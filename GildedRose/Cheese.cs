using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    public class Cheese : Item
    {
        public Cheese(string name, int sellIn, int quality) 
            : base(name, sellIn, quality)
        {
            
        }

        public override void UpdateQuality()
        {
            Quality = IncrementQuality(Quality);
            Quality = CheckQualityLimit(Quality);
        }

        private int IncrementQuality(int quality)
        {
            return ++quality;
        }

        

    }
}
