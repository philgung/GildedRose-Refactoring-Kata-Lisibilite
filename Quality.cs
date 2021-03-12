namespace csharp
{
    public class Quality
    {
        private const int MaxQuality = 50;
        private const int MinQuality = 0;

        private readonly int quality;

        public static Quality Zero = new Quality(0);

        public Quality(int quality)
        {
            if (quality <= MinQuality)
            {
                quality = MinQuality;
            }            
            else
            {
                this.quality = quality;
            }


        }
        public Quality Decrement() => new Quality(quality - 1);

        public Quality Increment()
        {
            int newQuality = quality + 1;
            if (newQuality > MaxQuality)
            {
                return this;
            }
            return new Quality(newQuality);
        }

        public Quality Reset() => Zero;
        public override string ToString() => quality.ToString();
    }
}