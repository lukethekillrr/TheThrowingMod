using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheThrowingMod.Accessories
{
    public class AttunedFossil : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Attuned Fossil");
            Tooltip.SetDefault("15% increased throwing speed\n15% increased throwing velocity");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 16;
            item.value = Item.sellPrice(0, 0, 20, 0);
            item.rare = 2;
            item.accessory = true;
            item.value = Item.buyPrice(0, 40, 0, 0);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.thrownVelocity += 0.15f;
            player.GetModPlayer<ThrowerPlayer>().thrownSpeed += 0.15f;
        }
    }
}