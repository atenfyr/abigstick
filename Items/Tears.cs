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
            item.rare = 3;
        }
    }

    public class MoonTears : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Lunar Tears");
            Tooltip.SetDefault("'Released during the Moon Lord's final cries of anguish'");
        }

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/MoonTears");
        }

        public override void SetDefaults() {
            item.value = 50000;
            item.maxStack = 999;
            item.rare = 9;
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
            item.value = 1000;
            item.maxStack = 1;
            item.rare = 3;
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
            recipe.AddIngredient(ItemID.HellstoneBar, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}