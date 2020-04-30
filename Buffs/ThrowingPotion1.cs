using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TheThrowingMod.Buffs
{
    public class ThrowingPotion1 : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Enhanced Throwing");
            Description.SetDefault("10% increased throwing damage, speed, velocity, and crit");
            Main.buffNoSave[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.thrownDamage += 0.1f;
            player.thrownVelocity += 0.1f;
            player.thrownCrit += 10;
            player.GetModPlayer<ThrowerPlayer>().thrownSpeed += 0.10f;
        }
    }
}