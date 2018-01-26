using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace ABigStick.Buffs.Abomination {
	public class ForceMourning : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Weeping");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Buffs/Mourning");
        }

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.rare = 9;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 4;
			item.UseSound = SoundID.Item44;
			item.consumable = true;
		}

		public override bool CanUseItem(Player player) {
			return true;
		}

		public override bool UseItem(Player player) {
			player.AddBuff(mod.BuffType("Mourning"), 10 * 60);
			return true;
		}
	}
}