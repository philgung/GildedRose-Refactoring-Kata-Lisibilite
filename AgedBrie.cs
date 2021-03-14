namespace csharp
{
    public class AgedBrie : Item
    {
        public AgedBrie(SellIn sellIn, Quality quality) : base(Constants.AgedBrie, sellIn, quality)
        {
        }

        internal override void UpdateQuality()
        {
            SellInValueApproaches();

            if (TheSellByDateHasPassed())
            {
                QualityIncreaseTwice();
            }
            else
            {
                IncreaseQuality();

            }
        }        
    }
}
