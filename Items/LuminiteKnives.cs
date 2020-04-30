using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace TheThrowingMod.Items
{
    public class LuminiteKnives : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hand of the Moon Lord");
            Tooltip.SetDefault("Life Stealing Knives Crafted from Fragments of the Moon");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(52, 13));
        }
        public override void SetDefaults()
        {
            item.damage = 160;
            item.width = 66;
            item.height = 66;
            item.useTime = 12;
            item.useAnimation = 12;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 45, 0, 0);
            item.rare = 9;
            item.UseSound = SoundID.Item39;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("LuminiteKnifeProj");
            item.shootSpeed = 17f;
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            int R = 102;
            int G = 255;
            int B = 255;
            bool GDecrease = false;
            bool RDecrease = false;
            if (R >= 102)
                RDecrease = true;
            if (R <= 51)
                RDecrease = false;
            if (RDecrease)
                R++;
            if (!RDecrease)
                R--;

            if (G >= 255)
                GDecrease = true;
            if (G <= 102)
                GDecrease = false;
            if (GDecrease)
                G++;
            if (!GDecrease)
                G--;
            foreach (TooltipLine line2 in tooltips)
            {
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                {
                    line2.overrideColor = new Color(R, G, B);
                }
                if (line2.mod == "Terraria" && line2.Name == "Damage")
                {
                    line2.overrideColor = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB);
                }
                if (line2.mod == "Terraria" && line2.Name == "CritChance")
                {
                    line2.overrideColor = new Color(Main.DiscoG, Main.DiscoR, Main.DiscoB);
                }
                if (line2.mod == "Terraria" && line2.Name == "Speed")
                {
                    line2.overrideColor = new Color(Main.DiscoB, Main.DiscoR, Main.DiscoG);
                }
                if (line2.mod == "Terraria" && line2.Name == "Knockback")
                {
                    line2.overrideColor = new Color(Main.DiscoG, Main.DiscoB, Main.DiscoR);
                }
                if (line2.mod == "Terraria" && line2.Name == "Tooltip0")
                {
                    line2.overrideColor = new Color(Main.DiscoR, Main.DiscoB, Main.DiscoG);
                }
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 20);
            recipe.AddIngredient(ItemID.FragmentVortex, 8);
            recipe.AddIngredient(ItemID.FragmentNebula, 8);
            recipe.AddIngredient(ItemID.FragmentSolar, 8);
            recipe.AddIngredient(ItemID.FragmentStardust, 8);
            recipe.AddIngredient(ItemID.VampireKnives, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 5 + Main.rand.Next(2); //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // This defines the projectiles random spread . 30 degree spread.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }
}