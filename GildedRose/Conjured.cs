using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    public class Conjured : Item
    {
        public Conjured(string name, int sellIn, int quality)
                : base(name, sellIn, quality)
        {

        }

        public override void UpdateQuality()
        {
            Quality = DecrementQuality(Quality);
            Quality = DecrementQualityExpired(Quality);
            Quality = CheckQualityLimit(Quality);
        }

        protected override int DecrementQuality(int quality)
        {
            return quality -2;
        }

        protected override int DecrementQualityExpired(int quality)
        {
            if (SellIn < 0)
            {
                return DecrementQuality(quality);
            }
            else
            {
                return quality;
            }
        }


    }
}
