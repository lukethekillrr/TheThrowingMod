using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using System;
using System.Collections.Generic;
using Terraria.ID;

namespace TheThrowingMod.RandomStuff
{
    class ThrowerFragment : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ThrowerFragment");
            Tooltip.SetDefault("ThrowerFragment");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.rare = 4;
            item.maxStack = 999;
        }
    }
}
