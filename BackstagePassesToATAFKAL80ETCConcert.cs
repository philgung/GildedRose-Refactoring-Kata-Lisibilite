using static csharp.Quality;
namespace csharp
{
    public class BackstagePasses : Item
    {
        public BackstagePasses(string concertName, SellIn sellIn, Quality quality) : 
            base($"{Constants.BackstagePasses} to a {concertName} concert", sellIn, quality)
        {
        }

        internal override void UpdateQuality()
        {
            //	- "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
            //        Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less
            SellInValueApproaches();

            IncreaseQuality();

            if (ThereAre5DaysLeftBeforeConcert())
            {
                IncreaseQuality();
            }

            if (ThereAre10DaysLeftBeforeConcert())
            {
                IncreaseQuality();
            }

            if (ConcertIsOver())
            {
                QualityDropsToZero();
            }
        }

        private bool ThereAre5DaysLeftBeforeConcert()
        {
            return SellIn.IsSmallerThan(5);
        }

        private bool ThereAre10DaysLeftBeforeConcert()
        {
            return SellIn.IsSmallerThan(10);
        }

        private bool ConcertIsOver() => TheSellByDateHasPassed();

        private void QualityDropsToZero()
        {
            Quality = Zero;
        }
    }
}
