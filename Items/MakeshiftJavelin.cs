using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheThrowingMod.Items
{
    public class MakeshiftJavelin : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Makeshift Javelin");
        }
        public override void SetDefaults()
        {
            item.shootSpeed = 12f;
            item.damage = 27;
            item.knockBack = 5f;
            item.useStyle = 1;
            item.useAnimation = 25;
            item.useTime = 25;
            item.width = 16;
            item.height = 16;
            item.maxStack = 1;
            item.rare = 3;

            item.consumable = false;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.autoReuse = true;
            item.thrown = true;

            item.UseSound = SoundID.Item1;
            item.shoot = mod.ProjectileType("MakeshiftJavelin");
            item.value = Item.sellPrice(0, 0, 0, 8);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.JungleSpores, 9);
            recipe.AddIngredient(ItemID.Stinger, 5);
            recipe.AddIngredient(ItemID.Vine, 1);
            recipe.AddIngredient(ItemID.RichMahogany, 10);
            recipe.anyWood = false;
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}