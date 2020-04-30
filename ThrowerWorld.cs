using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Generation;
using Terraria.World.Generation;
using System.Collections.Generic;
using static Terraria.ModLoader.ModContent;
using System;
using Terraria.ModLoader.IO;
using System.IO;

namespace TheThrowingMod
{
    public class ThrowerWorld : ModWorld
    {
        public static bool spawnOre = false;

        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Thrower Mod Ores", delegate (GenerationProgress progress)
                {
                    progress.Message = "Generating Thrower Ores";
                    for (int i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
                    {
                        WorldGen.TileRunner(
                            WorldGen.genRand.Next(0, Main.maxTilesX), // X Coord of the tile
                            WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY), // Y Coord of the tile
                            (double)WorldGen.genRand.Next(3, 6), // Strength (High = more)
                            WorldGen.genRand.Next(2, 6), // Steps 
                            mod.TileType("ThrowerOre"), // The tile type that will be spawned
                            false, // Add Tile ???
                            0f, // Speed X ???
                            0f, // Speed Y ???
                            false, // noYChange ??? 
                            true); // Overrides existing tiles
                    }
                }));
            }
        }
        public override void PostWorldGen()
        {

            // Place some items in Ice Chests
            int[] itemsToPlaceLockedGoldChests = { ItemType<Items.Riptide>() };
            int itemsToPlaceLockedGoldChestsChoice = 0;
            for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
            {
                Chest chest = Main.chest[chestIndex];
                // If you look at the sprite for Chests by extracting Tiles_21.xnb, you'll see that the 12th chest is the Ice Chest. Since we are counting from 0, this is where 11 comes from. 36 comes from the width of each tile including padding. 
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 2 * 36)
                {
                    for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                    {
                        if (chest.item[inventoryIndex].type == 0)
                        {
                            chest.item[inventoryIndex].SetDefaults(itemsToPlaceLockedGoldChests[itemsToPlaceLockedGoldChestsChoice]);
                            itemsToPlaceLockedGoldChestsChoice = (itemsToPlaceLockedGoldChestsChoice + 1) % itemsToPlaceLockedGoldChests.Length;
                            // Alternate approach: Random instead of cyclical: chest.item[inventoryIndex].SetDefaults(Main.rand.Next(itemsToPlaceInIceChests));
                            break;
                        }

                    }
                }
            }
        }
    }
}
    
