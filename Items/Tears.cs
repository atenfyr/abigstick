using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace ABigStick.Items {
    public class LastTears : ModItem {
        public override void SetStaticDefaults() {
            // DisplayName.SetDefault("Last Tears");
            // Tooltip.SetDefault("'Shed during someone's final moments'");
        }

        public override string Texture { get { return "ABigStick/Items/Tears"; } }

        public override void SetDefaults() {
            Item.value = 2000;
            Item.maxStack = 999;
            Item.rare = 3;
        }
    }

    public class MoonTears : ModItem {
        public override void SetStaticDefaults() {
            // DisplayName.SetDefault("Lunar Tears");
            // Tooltip.SetDefault("'Released during the Moon Lord's final cries of anguish'");
        }

        public override string Texture { get { return "ABigStick/Items/MoonTears"; } }

        public override void SetDefaults() {
            Item.value = 50000;
            Item.maxStack = 999;
            Item.rare = 9;
        }
    }

    public class TearNet : ModItem {
        public override void SetStaticDefaults() {
            // DisplayName.SetDefault("Net of Tears");
            // Tooltip.SetDefault("Allows you to harvest their final tears");
        }

        public override string Texture { get { return "ABigStick/Items/NetofTears"; } }

        public override void SetDefaults() {
            Item.value = 1000;
            Item.maxStack = 1;
            Item.rare = 3;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            player.GetModPlayer<ABigPlayer>().hasTearNet = true;
            if (!hideVisual) {
                player.AddBuff(Mod.Find<ModBuff>("Mourning").Type, 3 * 60);
            }
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.BugNet);
            recipe.AddIngredient(ItemID.HellstoneBar, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}