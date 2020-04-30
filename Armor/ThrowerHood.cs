using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TheThrowingMod.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class ThrowerHood : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This is a modded helmet.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 7;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ItemType<ThrowerBreastplate>() && legs.type == ItemType<ThrowerLeggings>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "trollface.jpg";
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Placeable.ThrowerBar>(), 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}