using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ABigStick.Buffs {
    public class Mourning : ModBuff {
        public override void SetStaticDefaults() {
            // DisplayName.SetDefault("Mourning");
            // Description.SetDefault("Tears are rolling down your eyes");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex) {
            Dust.NewDust((player.position + new Vector2(0, 5)), 0, 0, 253, 0f, 0f, 0, new Color(78,94,176), 0.6f);
        }

        public override void Update(NPC npc, ref int buffIndex) {
            Dust.NewDust((npc.position + new Vector2(0, 5)), 0, 0, 253, 0f, 0f, 0, new Color(78,94,176), 0.6f);
        }
    }
}