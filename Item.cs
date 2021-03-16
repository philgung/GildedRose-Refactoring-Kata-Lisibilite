namespace csharp
{
    public class Item
    {
        public string Name { get; }
        protected SellIn SellIn;
        protected Quality Quality;

        public Item(string name, SellIn sellIn, Quality quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }
        internal virtual void UpdateQuality()
        {
            SellInValueApproaches();

            if (TheSellByDateHasPassed())
            {
                QualityDegradesTwice();
            }
            else
            {
                DegradeQuality();
            }
        }

        
        public override string ToString() => $"{Name}, {SellIn}, {Quality}";

        private void QualityDegradesTwice()
        {
            Quality = Quality.Degrade(2);
        }
        protected void SellInValueApproaches()
        {
            SellIn = SellIn.Decrement();
        }

        protected void DegradeQuality()
        {
            Quality = Quality.Degrade();
        }

        protected void IncreaseQuality()
        {
            Quality = Quality.Increase();
        }

        protected bool TheSellByDateHasPassed() => SellIn.IsNegatif;
        protected void QualityIncreaseTwice()
        {
            IncreaseQuality();
            IncreaseQuality();
        }

    }
}
