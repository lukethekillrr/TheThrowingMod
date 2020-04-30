using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
namespace TheThrowingMod.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class JimboLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{

			Tooltip.SetDefault("Increased movement speed by 10%.");
			DisplayName.SetDefault("ThrowiumLeggings");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 17;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.10f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Placeable.ExampleBar>(), 12);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}