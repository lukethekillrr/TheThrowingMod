using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheThrowingMod.Accessories
{
    public class ThrowerEmblem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ThrowerEmblem");
            Tooltip.SetDefault("10% increased throwing damage");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.rare = 4;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.thrownDamage += 0.10f;
        }

    }
}