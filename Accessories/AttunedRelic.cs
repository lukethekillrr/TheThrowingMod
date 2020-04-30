using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheThrowingMod.Accessories
{
    public class AttunedRelic : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Attuned Relic");
            Tooltip.SetDefault("15% increased throwing damage and velocity\n15% increased throwing speed");
        }

        public override void SetDefaults()
        {
            item.width = 15;
            item.height = 14;
            item.value = Item.sellPrice(0, 0, 40, 0);
            item.rare = 2;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.thrownDamage += 0.15f;
            player.GetModPlayer<ThrowerPlayer>().thrownSpeed += 0.15f;
            player.thrownVelocity += 0.15f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("AttunedFossil"));
            recipe.AddIngredient(mod.ItemType("AttunedBone"));
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}