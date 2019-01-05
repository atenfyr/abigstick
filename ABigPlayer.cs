using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;

namespace ABigStick {
    public class ABigPlayer : ModPlayer {
        public bool hasTearNet = false;

        public override void ResetEffects() {
            hasTearNet = false;
        }

        public override void clientClone(ModPlayer clientClone) {
            ABigPlayer clone = clientClone as ABigPlayer;
        }

        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer) {
            ModPacket packet = mod.GetPacket();
            packet.Write((byte)player.whoAmI);
            packet.Send(toWho, fromWho);
        }
    }
}
