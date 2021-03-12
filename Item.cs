namespace csharp
{
    public class Item
    {
        protected const int MaxQuality = 50;

        public string Name { get; set; }
        public int SellIn { get; set; }
        public Quality Quality { get; set; }

        public override string ToString() => $"{Name}, {SellIn}, {Quality}";

        protected void DecrementSellIn()
        {
            SellIn--;
        }

        protected void DecrementQuality()
        {
            Quality = Quality.Decrement();
        }

        protected void IncrementQuality()
        {
            Quality = Quality.Increment();
        }

        internal virtual void UpdateQuality()
        {
            DecrementQuality();
            DecrementSellIn();
            if (SellIn < 0)
            {
                DecrementQuality();
            }
        }
    }

    public class AgedBrie : Item
    {
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

    public class BackstagePassesToATAFKAL80ETCConcert : Item
    {
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

    public class SulfurasHandOfRagnaros : Item
    {
        internal override void UpdateQuality()
        {
        }
    }
}
