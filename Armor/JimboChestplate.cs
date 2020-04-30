using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TheThrowingMod.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class JimboChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("ThrowiumChestplate");
			Tooltip.SetDefault("thrownVelocity %10."
				+ "\nImmunity to 'On Fire!'"
				+ "\n%10ThrownDamage");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 21;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.thrownVelocity += 0.10f;
			player.thrownDamage += 0.20f;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Placeable.ExampleBar>(), 16);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 17);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}