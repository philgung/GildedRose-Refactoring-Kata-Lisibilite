namespace csharp
{
    public class SulfurasHandOfRagnaros : Item
    {
        public SulfurasHandOfRagnaros(SellIn sellIn, Quality quality) : base(Constants.SulfurasHandOfRagnaros, sellIn, quality)
        {
        }

        internal override void UpdateQuality()
        {
        }
    }
}
