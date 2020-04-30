using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheThrowingMod.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class MythrilGalea : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Mythril Galea");
            Tooltip.SetDefault("12% increased throwing damage\n6% increased throwing speed\n7% increased throwing velocity");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 30;
            item.value = Item.sellPrice(0, 2, 25, 0);
            item.rare = 4;
            item.defense = 10;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemID.MythrilChainmail && legs.type == ItemID.MythrilGreaves;
        }

        public override void UpdateEquip(Player player)
        {
            player.thrownDamage += 0.12f;
            player.GetModPlayer<ThrowerPlayer>().thrownSpeed += 0.06f;
            player.thrownVelocity += 0.07f;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "20% chance not to consume ammo\n6% increased throwing speed";
            player.GetModPlayer<ThrowerPlayer>().thrownAmmoChance += 0.2f;
            player.GetModPlayer<ThrowerPlayer>().thrownSpeed += 0.06f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MythrilBar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}