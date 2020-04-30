using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheThrowingMod.Accessories
{
    public class opdontuse : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("opdontuse");
            Tooltip.SetDefault("1000% increased throwing damage");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 16;
            item.value = Item.sellPrice(0, 0, 20, 0);
            item.rare = 2;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.thrownDamage += 2.00f;
            player.allDamage += 2.00f;
        }
    }
}