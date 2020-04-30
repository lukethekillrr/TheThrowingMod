using Terraria.ModLoader;

namespace TheThrowingMod
{
    class TheThrowingMod : Mod
    {
        public TheThrowingMod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true

            };
        }
    }
}
