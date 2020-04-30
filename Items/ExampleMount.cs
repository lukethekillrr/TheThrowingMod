using Terraria.ModLoader;

namespace TheThrowingMod.Items
{
    public class ExampleMount : ModItem
    {
        public override void SetDefaults()
        {

            item.width = 20;
            item.height = 30;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.value = 300;
            item.rare = 5;
            item.noMelee = true;
            item.mountType = mod.MountType("ExmapleMount");
        }


    }
}