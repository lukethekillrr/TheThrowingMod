using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheThrowingMod.Items
{
	public class BeeKnives : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bee Knives");
			Tooltip.SetDefault("Life Stealing Knives Covered in Bees");
		}
		public override void SetDefaults()
		{
			item.damage = 39;
			item.width = 32;
			item.height = 32;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = Item.sellPrice(0, 0, 54, 20);
			item.rare = 8;
			item.UseSound = SoundID.Item97;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("BeeKnifeProj");
			item.shootSpeed = 15f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HoneyBlock, 50);
			recipe.AddIngredient(ItemID.VampireKnives, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 4 + Main.rand.Next(2); //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // This defines the projectiles random spread . 30 degree spread.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
	}
}
