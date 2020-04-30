using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using System.Linq;
using System;
using TheThrowingMod;
using Terraria.Utilities;
namespace TheThrowingMod.NPCs
{
    public class NpcDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {

            if (npc.type == NPCID.Plantera) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {
                if (!ThrowerWorld.spawnOre)
                {                                                          //Red  Green Blue
                    Main.NewText("The world has been blessed with Custom Ore", 200, 200, 55);  //this is the message that will appear when the npc is killed  , 200, 200, 55 is the text color
                    for (int k = 0; k < (int)((double)(WorldGen.rockLayer * Main.maxTilesY) * 40E-05); k++)   //40E-05 is how many veins ore is going to spawn , change 40 to a lover value if you want less vains ore or higher value for more veins ore
                    {
                        int X = WorldGen.genRand.Next(0, Main.maxTilesX);
                        int Y = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY - 200); //this is the coordinates where the veins ore will spawn, so in Cavern layer
                        WorldGen.OreRunner(X, Y, WorldGen.genRand.Next(3, 9), WorldGen.genRand.Next(2, 6), (ushort)mod.TileType("ThrowiumOreHardMode"));   //WorldGen.genRand.Next(9, 15), WorldGen.genRand.Next(5, 9) is the vein ore sizes, so 9 to 15 blocks or 5 to 9 blocks, mod.TileType("CustomOreTile") is the custom tile that will spawn
                    }
                }
                ThrowerWorld.spawnOre = true;   //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == NPCID.WallofFlesh)
            {
                if (Main.rand.Next(6) == 0)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("ThrowerEmblem"));

                }
            }
            if (npc.type == NPCID.Plantera)
            {

                Item.NewItem(npc.getRect(), ItemType<Items.Waspnade>(), Main.rand.Next(80, 100));


            }

            if (npc.type == NPCID.LunarTowerStardust)
            {

                Item.NewItem(npc.getRect(), ItemType<RandomStuff.ThrowerFragment>(), Main.rand.Next(6, 12));

            }
            if (npc.type == NPCID.LunarTowerSolar)
            {

                Item.NewItem(npc.getRect(), ItemType<RandomStuff.ThrowerFragment>(), Main.rand.Next(6, 12));
            }
            if (npc.type == NPCID.LunarTowerVortex)
            {

                Item.NewItem(npc.getRect(), ItemType<RandomStuff.ThrowerFragment>(), Main.rand.Next(6, 12));
            }
            if (npc.type == NPCID.LunarTowerNebula)
            {

                Item.NewItem(npc.getRect(), ItemType<RandomStuff.ThrowerFragment>(), Main.rand.Next(6, 12));
            }
        }
    }
}

