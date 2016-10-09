using Rocket.API;

namespace AutoDropsTimer
{
     public class AutoAirdropGIGConfig : IRocketPluginConfiguration
{
        public bool Enabled = true;
        public ushort Frequency = 2500;

        public void LoadDefaults()
        {
           
        }
    }
}
