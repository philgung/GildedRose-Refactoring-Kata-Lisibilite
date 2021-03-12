using System;
using System.Collections.Generic;
using static csharp.Quality;
namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = new Quality(20)},
                new AgedBrie {Name = Constants.AgedBrie, SellIn = 2, Quality = Zero},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = new Quality(7)},
                new SulfurasHandOfRagnaros {Name = Constants.SulfurasHandOfRagnaros, SellIn = 0, Quality = new Quality(80)},
                new SulfurasHandOfRagnaros {Name = Constants.SulfurasHandOfRagnaros, SellIn = -1, Quality = new Quality(80)},
                new BackstagePassesToATAFKAL80ETCConcert
                {
                    Name = Constants.BackstagePassesToATAFKAL80ETCConcert,
                    SellIn = 15,
                    Quality = new Quality(20)
                },
                new BackstagePassesToATAFKAL80ETCConcert
                {
                    Name = Constants.BackstagePassesToATAFKAL80ETCConcert,
                    SellIn = 10,
                    Quality = new Quality(49)
                },
                new BackstagePassesToATAFKAL80ETCConcert
                {
                    Name = Constants.BackstagePassesToATAFKAL80ETCConcert,
                    SellIn = 5,
                    Quality = new Quality(49)
                },
                // this conjured item does not work properly yet
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = new Quality(6)}
            };

            var app = new GildedRose(Items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
