using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace ABigStick.Items {
    public class LastTears : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Last Tears");
            Tooltip.SetDefault("'Collected from a dying god'");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/Tears");
        }

        public override void SetDefaults() {
			item.value = 2000;
            item.maxStack = 999;
            item.rare = 9;
        }
    }
}