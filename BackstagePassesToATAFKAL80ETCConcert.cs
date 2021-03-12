namespace csharp
{
    public class BackstagePassesToATAFKAL80ETCConcert : Item
    {
        public BackstagePassesToATAFKAL80ETCConcert(int sellIn, Quality quality) : base(Constants.BackstagePassesToATAFKAL80ETCConcert, sellIn, quality)
        {
        }

        internal override void UpdateQuality()
        {
            IncrementQuality();

            if (SellIn < 11)
            {
                IncrementQuality();
            }

            if (SellIn < 6)
            {
                IncrementQuality();
            }

            DecrementSellIn();
            if (SellIn < 0)
            {
                Quality = Quality.Reset();
            }
        }
    }
}
