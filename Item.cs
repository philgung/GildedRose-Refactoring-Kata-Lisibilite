namespace csharp
{
    public class Item
    {
        public string Name { get; }
        protected int SellIn;
        protected Quality Quality;

        public Item(string name, int sellIn, Quality quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }
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
}
