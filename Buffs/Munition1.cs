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
    public class Munition1 : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Munition 1");
            Description.SetDefault("+20% chance to shoot up to 2 more shots");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<ThrowerPlayer>().Munition1 = true;
        }
    }
}