using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TheThrowingMod.NPCs
{
    public class Mimic : ModNPC
    {
        public override void SetDefaults()
        {
            npc.width = 40;
            npc.height = 30;
            npc.damage = 10;
            npc.defense = 10;
            npc.lifeMax = 100;
            npc.value = 60f;
            npc.knockBackResist = 0.5f;
            npc.aiStyle = 44;
            Main.npcFrameCount[npc.type] = 3;
            aiType = NPCID.Mimic;
            animationType = NPCID.Mimic;
            banner = Item.NPCtoBanner(NPCID.Mimic);
            bannerItem = Item.BannerToItem(banner);
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Underground.Chance * 0.25f;
        }

        public override void NPCLoot()
        {
            Item.NewItem(npc.position, mod.ItemType("ExampleSoul"));

            if (Main.rand.Next(4) == 0)
            {
                Item.NewItem(npc.position, ItemID.Chest, 0);
            }

            if (Main.hardMode)
            {
                Item.NewItem(npc.position, ItemID.DynastyChest, 0);
            }
        }
    }
}
