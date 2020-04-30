using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheThrowingMod.Items
{
    public class CosmicPlanetCutter : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 100;           //this is the item damage
            item.thrown = true;             //this make the item do throwing damage
            item.noMelee = true;
            item.width = 20;
            item.height = 20;
            item.useTime = 10;       //this is how fast you use the item
            item.useAnimation = 30;   //this is how fast the animation when the item is used
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10;
            item.rare = 1;
            item.reuseDelay = 10;    //this is the item delay
            item.shoot = mod.ProjectileType("CosmicPlanetCutter");  //javelin projectile
            item.shootSpeed = 8f;     //projectile speed
            item.useTurn = true;
            item.maxStack = 5;       //this is the max stack of this item
            item.consumable = false;  //this make the item consumable when used
            item.noUseGraphic = true;
            item.autoReuse = true;
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentNebula, 15);
            recipe.AddIngredient(ItemID.Javelin, 100);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
