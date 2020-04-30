using Terraria;
using Terraria.ModLoader;

namespace TheThrowingMod.Buffs
{
    public class ExampleMountBuff : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType("ExampleMount"), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}