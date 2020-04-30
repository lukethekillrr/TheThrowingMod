using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheThrowingMod.Accessories
{
    [AutoloadEquip(EquipType.Shield)]
    public class SpartanRelicShield : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spartan Relic Shield");
            Tooltip.SetDefault("15% increased throwing damage and velocity\n15% increased throwing speed\nGrants the ability to dash");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 28;
            item.value = Item.sellPrice(0, 2, 40, 0);
            item.rare = 4;
            item.accessory = true;
            item.defense = 2;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.thrownDamage += 0.15f;
            player.GetModPlayer<ThrowerPlayer>().thrownSpeed += 0.15f;
            player.thrownVelocity += 0.15f;
            player.dash = 2;
            if (Main.rand.Next(250) == 0) //On a 1/250 chance every tick, it'll spawn a projectile (to prevent lag)
            {
                float vel = 12f;
                if (player.direction == -1)
                {
                    vel = -12f;
                }
                Projectile.NewProjectile(player.position.X, player.position.Y+12, vel, 0f, mod.ProjectileType("Beenade"), 40, 5f, Main.myPlayer);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SpartanShield"));
            recipe.AddIngredient(mod.ItemType("AttunedRelic"));
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}