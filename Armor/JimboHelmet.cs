using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
namespace TheThrowingMod.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class JimboHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("ThrowiumHelmet.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 22;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemType<ThrowerBreastplate>() && legs.type == ItemType<ThrowerLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "10% throwndamage";
			player.thrownDamage += 0.10f;
			/* Here are the individual weapon class bonuses.
			player.meleeDamage -= 0.2f;
			player.thrownDamage -= 0.2f;
			player.rangedDamage -= 0.2f;
			player.magicDamage -= 0.2f;
			player.minionDamage -= 0.2f;
			*/
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Placeable.ExampleBar>(), 13);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}