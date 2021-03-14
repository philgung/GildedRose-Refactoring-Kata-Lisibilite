using static csharp.Quality;
using static System.Console;
using static System.Linq.Enumerable;
namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("OMGHAI!");

            var items = new []{
                new Item("+5 Dexterity Vest", new SellIn(10), new Quality(20)),
                new AgedBrie(new SellIn(2), Zero),
                new Item("Elixir of the Mongoose", new SellIn(5), new Quality(7)),
                new SulfurasHandOfRagnaros(SellIn.Zero, new Quality(80)),
                new SulfurasHandOfRagnaros(new SellIn(-1), new Quality(80)),
                new BackstagePasses("TAFKAL80ETC", new SellIn(15), new Quality(20)),
                new BackstagePasses("TAFKAL80ETC", new SellIn(10), new Quality(49)),
                new BackstagePasses("TAFKAL80ETC", new SellIn(5), new Quality(49)),
                // this conjured item does not work properly yet
                new Item("Conjured Mana Cake", new SellIn(3), new Quality(6))
            };

            var app = new GildedRose(items);

            
            foreach (var dayNumber in Range(0, 31))
            {
                WriteLine($"-------- day {dayNumber} --------");
                WriteLine("name, sellIn, quality");
                foreach (var item in items)
                {
                    WriteLine(item);
                }
                WriteLine(string.Empty);
                app.UpdateQuality();
            }
        }
    }
}
