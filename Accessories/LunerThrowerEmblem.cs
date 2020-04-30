using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using System;
using System.Collections.Generic;
using Terraria.ID;

namespace TheThrowingMod.Accessories
{
    public class LunerThrowerEmblem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("LunerThrowerEmblem");
            Tooltip.SetDefault("25% increased throwing damage");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.value = Item.sellPrice(0, 50, 0, 0);
            item.rare = 4;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.thrownDamage += 0.25f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<RandomStuff.ThrowerFragment>(), 19);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

        }
    }
}