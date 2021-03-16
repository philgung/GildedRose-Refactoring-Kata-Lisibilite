namespace csharp
{
    public class SellIn
    {
        private readonly int _sellIn;

        public static SellIn Zero = new SellIn(0);
        public SellIn(int sellIn)
        {
            _sellIn = sellIn;
        }
        internal bool IsNegatif => IsSmallerThan(0);

        internal bool IsSmallerThan(int value) => _sellIn < value;

        internal SellIn Decrement() => new SellIn(_sellIn - 1);

        public override string ToString() => _sellIn.ToString();
    }
}