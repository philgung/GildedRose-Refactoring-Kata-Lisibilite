namespace csharp
{
    public class Quality
    {

//        	- Once the sell by date has passed, Quality degrades twice as fast


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

        public Quality Degrade() => new Quality(quality - 1);

        public Quality Increase()
        {
            int newQuality = quality + 1;
            if (newQuality > MaxQuality)
            {
                return this;
            }
            return new Quality(newQuality);
        }

        public override string ToString() => quality.ToString();
    }
}