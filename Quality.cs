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

        public Quality Increase()
        {
            var newQuality = quality + 1;
            if (IsMoreThanMaxQuality(newQuality))
            {
                return this;
            }
            return new Quality(newQuality);
        }

        private static bool IsMoreThanMaxQuality(int newQuality) => newQuality > MaxQuality;

        public override string ToString() => quality.ToString();
    }
}