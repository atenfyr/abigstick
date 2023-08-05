using Terraria.ModLoader;

namespace ABigStick {
    public class ABigPlayer : ModPlayer {
        public bool hasTearNet = false;

        public override void ResetEffects() {
            hasTearNet = false;
        }

        public override void CopyClientState(ModPlayer clientClone)/* tModPorter Suggestion: Replace Item.Clone usages with Item.CopyNetStateTo */ {
            ABigPlayer clone = clientClone as ABigPlayer;
            clone.hasTearNet = hasTearNet;
        }

        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer) {
            ModPacket packet = Mod.GetPacket();
            packet.Write((byte)ABigStickMessageType.SyncABigPlayer);
            packet.Write((byte)Player.whoAmI);
            packet.Write((bool)hasTearNet);
            packet.Send(toWho, fromWho);
        }

        public override void SendClientChanges(ModPlayer clientPlayer)
        {
            ABigPlayer clone = clientPlayer as ABigPlayer;
            if (clone.hasTearNet != hasTearNet)
            {
                // Send a Mod Packet with the changes.
                var packet = Mod.GetPacket();
                packet.Write((byte)ABigStickMessageType.SyncABigPlayer);
                packet.Write((byte)Player.whoAmI);
                packet.Write((bool)hasTearNet);
                packet.Send();
            }
        }
    }
}
