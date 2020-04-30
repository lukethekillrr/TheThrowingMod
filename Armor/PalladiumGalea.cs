using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheThrowingMod.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class PalladiumGalea : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Palladium Galea");
            Tooltip.SetDefault("9% increased throwing damage\n5% increased throwing speed\n9% increased throwing velocity");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 30;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 4;
            item.defense = 9;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemID.PalladiumBreastplate && legs.type == ItemID.PalladiumLeggings;
        }

        public override void UpdateEquip(Player player)
        {
            player.thrownDamage += 0.09f;
            player.GetModPlayer<ThrowerPlayer>().thrownSpeed += 0.05f;
            player.thrownVelocity += 0.09f;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Greatly increases life regeneration after striking an enemy\n5% increased throwing speed";
            player.GetModPlayer<ThrowerPlayer>().PalladiumGalea = true;
            player.GetModPlayer<ThrowerPlayer>().thrownSpeed += 0.05f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PalladiumBar, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}