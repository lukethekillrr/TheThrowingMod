using Terraria;
using Terraria.ModLoader;


namespace TheThrowingMod.Buffs
{
    public class TitaniumGaleaHit : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Shadow Dodge Cooldown");
            Description.SetDefault("3 Second Cooldown");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<ThrowerPlayer>().TitaniumGaleaHit = true;
        }
    }
}