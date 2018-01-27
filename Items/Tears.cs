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
            Tooltip.SetDefault("'Shed during someone's final moments'");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/Tears");
        }

        public override void SetDefaults() {
			item.value = 2000;
            item.maxStack = 999;
            item.rare = 9;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 5;
            item.consumable = true;
        }

		public override bool CanUseItem(Player player) {
			return !(player.HasBuff(mod.BuffType("Mourning")));
		}

		public override bool UseItem(Player player) {
			player.AddBuff(mod.BuffType("Mourning"), 20 * 60);
			return true;
		}
    }

    public class TearNet : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Net of Tears");
            Tooltip.SetDefault("Allows you to harvest their final tears");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/NetofTears");
        }

        public override void SetDefaults() {
			item.value = 20000;
            item.maxStack = 999;
            item.rare = 9;
			item.accessory = true;
        }

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetModPlayer<ABigPlayer>(mod).hasTearNet = true;
			if (!hideVisual) {
				player.AddBuff(mod.BuffType("Mourning"), 3 * 60);
			}
		}

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BugNet);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.SpectreBar, 10);
			
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}