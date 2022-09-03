using System;
using Terraria;
using Terraria.ModLoader;

namespace ABigStick.Buffs {
    public class Cardio : ModBuff {
        public override void SetDefaults() {
            DisplayName.SetDefault("Cardio");
            Description.SetDefault("This is some good exercise");
        }

        public override void Update(Player player, ref int buffIndex) {
            player.statLifeMax2 = (int)Math.Floor((float)player.statLifeMax2*1.5f);
        }
    }
}