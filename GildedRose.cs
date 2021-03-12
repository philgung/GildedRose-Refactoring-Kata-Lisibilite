﻿using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        readonly IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var current in Items)
            {
                current.UpdateQuality();
            }
        }


    }
}
