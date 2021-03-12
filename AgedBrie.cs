namespace csharp
{
    public class AgedBrie : Item
    {
        public AgedBrie(int sellIn, Quality quality) : base(Constants.AgedBrie, sellIn, quality)
        {
        }

        internal override void UpdateQuality()
        {
            IncrementQuality();
            DecrementSellIn();
            if (SellIn < 0)
            {
                IncrementQuality();
            }
        }
    }
}
