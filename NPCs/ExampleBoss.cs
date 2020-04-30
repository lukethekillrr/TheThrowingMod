using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheThrowingMod.NPCs
{ [AutoloadBossHead]
   public class ExampleBoss : ModNPC
    {
        public override void SetDefaults()
        {
            npc.aiStyle = 5;
            npc.lifeMax = 5000;
            npc.damage = 100;
            npc.defense = 15;
            npc.knockBackResist = 0f;
            npc.width = 100;
            npc.height = 100;
            animationType = NPCID.DemonEye;
            Main.npcFrameCount[npc.type] = 3;
            npc.value = Item.sellPrice(0, 5, 75, 45);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.buffImmune[24] = true;
            music = MusicID.Boss2;
            npc.netAlways = true;
        }
        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = ItemID.GreaterHealingPotion;
        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
        }
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 3;
            NPCID.Sets.ExtraFramesCount[npc.type] = 3;
            NPCID.Sets.AttackFrameCount[npc.type] = 3;
        }

    }
}
