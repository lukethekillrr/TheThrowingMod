using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using static Terraria.ModLoader.ModContent;
using TheThrowingMod;

namespace TheThrowingMod.Buffs
{
    public class Munition2 : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Munition 2");
            Description.SetDefault("+20% Chance to not consume ammo");
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<ThrowerPlayer>().thrownAmmoChance += 0.2f;
        }
    }
}