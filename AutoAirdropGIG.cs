using System;
using UnityEngine;
using Rocket.API;
using Rocket.Unturned.Player;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Commands;
using System.Collections.Generic;
using SDG.Unturned;

namespace AutoDropsTimer
{
    public class AutoDrops : RocketPlugin<AutoAirdropGIGConfig>
    {
        private DateTime lastCalled = DateTime.Now;

        protected override void Load()
        {
            Rocket.Core.Logging.Logger.LogWarning("\tAutoAirdop by Marek44 Loaded Successfully!");
            checkChat();
        }

        protected override void Unload()
        {
            Rocket.Core.Logging.Logger.LogWarning("\tAutoAirdrop by Marek44 Unloaded Successfully!");
        }

        private void checkChat()
        {
            if ((DateTime.Now - this.lastCalled).TotalSeconds > 1200)
            {
                SendMSG();
                RunDrop();
                this.lastCalled = DateTime.Now;
                FixedUpdate();
            }
        }
        public static void SendMSG()
        {
            UnturnedChat.Say("Airdrop Comming? Find It!");
        }

        public void RunDrop()
        {
        }
        public void FixedUpdate()
        {
            if ((DateTime.Now - this.lastCalled).TotalSeconds > 1)
            {
                checkChat();
            }
        }
    }
}
