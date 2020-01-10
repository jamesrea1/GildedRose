using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    public class BackstagePasses : Item
    {
        public BackstagePasses(string name, int sellIn, int quality)
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
            if (SellIn >= 10)
                quality = quality + 1;
            else if (SellIn >= 5)
                quality = quality + 2;
            else if (SellIn >= 0)
                quality = quality + 3;
            else
                quality = 0;

            return quality;
        }





    }
}
