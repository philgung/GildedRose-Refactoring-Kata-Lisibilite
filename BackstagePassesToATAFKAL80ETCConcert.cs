using static csharp.Quality;
namespace csharp
{
    public class BackstagePassesToATAFKAL80ETCConcert : Item
    {
        public BackstagePassesToATAFKAL80ETCConcert(SellIn sellIn, Quality quality) : base(Constants.BackstagePassesToATAFKAL80ETCConcert, sellIn, quality)
        {
        }

        internal override void UpdateQuality()
        {
            //	- "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
            //        Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but

            IncreaseQuality();

            if (SellIn.IsSmallerThan(11))
            {
                IncreaseQuality();
            }

            if (SellIn.IsSmallerThan(6))
            {
                IncreaseQuality();
            }

            DegradeSellIn();
            if (ConcertIsOver())
            {
                QualityDropsToZero();
            }
        }

        private bool ConcertIsOver()
        {
            return SellIn.IsNegatif;
        }

        private void QualityDropsToZero()
        {
            Quality = Zero;
        }
    }
}
