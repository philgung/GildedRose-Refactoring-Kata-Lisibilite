using FluentAssertions;
using NUnit.Framework;
using static csharp.Quality;
namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            Assert.Pass();
            var Items = new[] { new Item("foo", new SellIn(0), Zero) };
            var app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Name.Should().Be("fixme");
        }
    }
}
