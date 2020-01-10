using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        enum ItemValidity { ValidItem, InvalidItem };
        ItemValidity Validity { get; }

        public Item(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;

            Validity = (Name.Equals("INVALID ITEM")) ? ItemValidity.InvalidItem : ItemValidity.ValidItem;
        }

        public virtual void UpdateSellIn()
        {
            SellIn--;
        }

        public virtual void UpdateQuality()
        {
            Quality = DecrementQuality(Quality);
            Quality = DecrementQualityExpired(Quality);
            Quality = CheckQualityLimit(Quality);
        }

        protected virtual int DecrementQuality(int quality)
        {
            return --quality;
        }

        protected virtual int DecrementQualityExpired(int quality)
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

        protected int CheckQualityLimit(int quality)
        {
            if (quality > 50)
                quality = 50;
            if (quality < 0)
                quality = 0;

            return quality;
        }

        public override string ToString()
        {
            if(Validity == ItemValidity.ValidItem)
            {
                return $"{Name}\t{SellIn} {Quality}";
            }
            else
            {
                return "NO SUCH ITEM";
            }
        }

    }
}
