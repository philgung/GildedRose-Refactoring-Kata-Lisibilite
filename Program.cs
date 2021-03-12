using System.Collections.Generic;
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
                new Item ("+5 Dexterity Vest", 10, new Quality(20)),
                new AgedBrie(2, Zero),
                new Item ("Elixir of the Mongoose", 5, new Quality(7)),
                new SulfurasHandOfRagnaros(0, new Quality(80)),
                new SulfurasHandOfRagnaros(-1, new Quality(80)),
                new BackstagePassesToATAFKAL80ETCConcert(15, new Quality(20)),
                new BackstagePassesToATAFKAL80ETCConcert(10, new Quality(49)),
                new BackstagePassesToATAFKAL80ETCConcert(5, new Quality(49)),
                // this conjured item does not work properly yet
                new Item ("Conjured Mana Cake", 3, new Quality(6))
            };

            var app = new GildedRose(items);

            
            foreach (var i in Range(0, 31))
            {
                WriteLine($"-------- day {i} --------");
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
