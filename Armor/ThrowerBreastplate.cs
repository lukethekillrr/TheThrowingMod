using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TheThrowingMod.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class ThrowerBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Example Breastplate");
			Tooltip.SetDefault("This is a modded body armor."
				+ "\nImmunity to 'On Fire!'"
				+ "\n+20 max mana and +1 max minions");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 7;
		}

		public override void UpdateEquip(Player player) {
			player.buffImmune[BuffID.OnFire] = true;
			player.thrownVelocity += 0.1f;
			player.thrownDamage += 0.1f;

		}

		public override void AddRecipes() {
			 ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<Placeable.ThrowerBar>(), 13);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}