using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheThrowingMod.Items
{
    public class InfiniteBeenades : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("InfiniteBeenade");
            Tooltip.SetDefault("Explodes upon contact");
        }
        public override void SetDefaults()
        {
            item.shootSpeed = 8f;
            item.damage = 26;
            item.knockBack = 1f;
            item.useStyle = 1;
            item.useAnimation = 24;
            item.useTime = 24;
            item.width = 14;
            item.height = 22;
            item.maxStack = 999;
            item.rare = 7;
            item.ammo = ItemID.Grenade;

            item.consumable = false;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.autoReuse = true;
            item.thrown = true;

            item.UseSound = SoundID.Item1;
            item.shoot = ProjectileID.Beenade;
            item.value = Item.sellPrice(0, 0, 1, 0);
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Beenade, 999);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}