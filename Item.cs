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
            DegradeQuality();
            DegradeSellIn();
            if (SellIn.IsNegatif)
            {
                DegradeQuality();
            }
        }
        public override string ToString() => $"{Name}, {SellIn}, {Quality}";

        protected void DegradeSellIn()
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
        
    }
}
