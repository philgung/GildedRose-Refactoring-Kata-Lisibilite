namespace csharp
{
    public class AgedBrie : Item
    {
        public AgedBrie(SellIn sellIn, Quality quality) : base(Constants.AgedBrie, sellIn, quality)
        {
        }

        internal override void UpdateQuality()
        {
            //	- "Aged Brie" actually increases in Quality the older it gets
            //	- The Quality of an item is never more than 50

            IncreaseQuality();
            DegradeSellIn();
            if (SellIn.IsNegatif)
            {
                IncreaseQuality();
            }
        }
    }
}
