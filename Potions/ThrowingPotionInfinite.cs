using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheThrowingMod.Potions
{
    public class ThrowingPotionInfinite : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Infinite Throwing Potion");
            Tooltip.SetDefault("10% increased throwing damage, speed, velocity, and crit");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 30;
            item.useAnimation = 16;
            item.useTime = 16;
            item.useStyle = 4;
            item.consumable = false;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 4, 0, 0);
            item.rare = 1;
            item.buffType = mod.BuffType("ThrowingPotion1");
            item.buffTime = 216000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("ThrowingPotion"), 30);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}