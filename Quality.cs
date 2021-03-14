namespace csharp
{
    public class Quality
    {

//We have recently signed a supplier of conjured items.This requires an update to our system:

//	- "Conjured" items degrade in Quality twice as fast as normal items

        private const int MaxQuality = 50;
        private const int MinQuality = 0;

        private readonly int quality;

        public static Quality Zero = new Quality(0);

        public Quality(int quality)
        {
            this.quality = IsNegative(quality) ?
                                MinQuality :
                                quality;
        }

        private static bool IsNegative(int quality) => quality < MinQuality;

        public Quality Degrade(int value = 1) => new Quality(quality - value);

        public Quality Increase(int value = 1)
        {
            //	- The Quality of an item is never more than 50

            int newQuality = quality + value;
            if (newQuality > MaxQuality)
            {
                return this;
            }
            return new Quality(newQuality);
        }

        public override string ToString() => quality.ToString();
    }
}