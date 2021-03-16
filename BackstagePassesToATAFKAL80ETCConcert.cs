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
            SellInValueApproaches();

            if (ThereAre5DaysLeftBeforeConcert())
            {
                QualityIncreasesBy3();
            }
            else if (ThereAre10DaysLeftBeforeConcert())
            {
                QualityIncreaseTwice();
            }
            else
            {
                IncreaseQuality();
            }

            if (ConcertIsOver())
            {
                QualityDropsToZero();
            }
        }

        private void QualityIncreasesBy3()
        {
            QualityIncreaseTwice();
            IncreaseQuality();
        }

        private bool ThereAre5DaysLeftBeforeConcert() => SellIn.IsSmallerThan(5);

        private bool ThereAre10DaysLeftBeforeConcert() => SellIn.IsSmallerThan(10);

        private bool ConcertIsOver() => TheSellByDateHasPassed();

        private void QualityDropsToZero()
        {
            Quality = Zero;
        }
    }
}
