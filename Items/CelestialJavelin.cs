﻿using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheThrowingMod.Items
{
    public class CelestialJavelin : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 160;           //this is the item damage
            item.thrown = true;             //this make the item do throwing damage
            item.noMelee = true;
            item.width = 20;
            item.height = 20;
            item.useTime = 9;       //this is how fast you use the item
            item.useAnimation = 30;   //this is how fast the animation when the item is used
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10;
            item.rare = 1;
            item.reuseDelay = 9;    //this is the item delay
            item.shoot = mod.ProjectileType("CelestialJavelin");  //javelin projectile
            item.shootSpeed = 8f;     //projectile speed
            item.useTurn = true;
            item.maxStack = 999;       //this is the max stack of this item
            item.consumable = true;  //this make the item consumable when used
            item.noUseGraphic = true;
            item.autoReuse = true;
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentSolar, 1);
            recipe.AddIngredient(ItemID.FragmentVortex, 1);
            recipe.AddIngredient(ItemID.Javelin, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}

