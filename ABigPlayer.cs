using Terraria.ModLoader;

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
