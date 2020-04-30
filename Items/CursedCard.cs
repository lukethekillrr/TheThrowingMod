using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheThrowingMod.Items
{
	public class CursedCard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cursed Card");
			Tooltip.SetDefault("'It hurts? Yes, of curse'");
		}

		public override void SetDefaults()
		{
			item.useStyle = 3;
			item.width = 13;
			item.height = 20;
			item.rare = 5;
			item.maxStack = 999;
			item.consumable = true;
			item.shootSpeed = 10.0f;
			item.UseSound = SoundID.Item1;
			item.useAnimation = 15;
			item.useTime = 15;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.value = 1000;
			item.damage = 30;
			item.thrown = true;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("CursedCard");
			item.crit = 6;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("DeckCard"), 25);
			recipe.AddIngredient(ItemID.CursedFlame);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}
	}
}