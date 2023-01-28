using System.IO;
using Terraria;
using Terraria.ModLoader;

namespace ABigStick
{
    public enum ABigStickMessageType
    {
        SyncABigPlayer
    }

    class ABigStick : Mod
    {
        public ABigStick()
        {
            this.ContentAutoloadingEnabled = true;
            this.GoreAutoloadingEnabled = true;
            this.MusicAutoloadingEnabled = true;
            this.BackgroundAutoloadingEnabled = true;
        }

        public override void HandlePacket(BinaryReader reader, int whoAmI)
        {
            ABigStickMessageType msgType = (ABigStickMessageType)reader.ReadByte();
            switch (msgType)
            {
                case ABigStickMessageType.SyncABigPlayer:
                    byte playernumber = reader.ReadByte();
                    ABigPlayer bigPlayer = Main.player[playernumber].GetModPlayer<ABigPlayer>();
                    bigPlayer.hasTearNet = reader.ReadBoolean();
                    break;
            }
        }
    }
}
