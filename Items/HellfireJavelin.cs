using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheThrowingMod.Items
{
    public class HellfireJavelin : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hellfire Javelin");
            Tooltip.SetDefault("Explodes upon contact");
        }
        public override void SetDefaults()
        {
            item.shootSpeed = 11f;
            item.damage = 35;
            item.knockBack = 5f;
            item.useStyle = 1;
            item.useAnimation = 25;
            item.useTime = 25;
            item.width = 16;
            item.height = 16;
            item.maxStack = 1;
            item.rare = 4;

            item.consumable = false;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.autoReuse = true;
            item.thrown = true;

            item.UseSound = SoundID.Item1;
            item.shoot = mod.ProjectileType("HellfireJavelin");
            item.value = Item.sellPrice(0, 0, 20, 0);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 12);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}