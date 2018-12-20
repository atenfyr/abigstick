using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;

namespace ABigStick.Items {
    /*
        It's quicker not to ask
    */
    public class CardioCrystal : ModItem {
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Cardio Crystal");
			Tooltip.SetDefault("Increases max life by 50%\n30 second duration\n'Dancing to the beat of your heart'");
		}

		public override void SetDefaults() {
			item.width = 64;
			item.height = 64;
			item.maxStack = 3;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 4;
			item.consumable = true;
            item.rare = 7;
		}

		public override bool UseItem(Player player) {
			player.AddBuff(mod.BuffType("Cardio"), 30 * 60);
			return true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.LifeFruit);
            recipe.AddIngredient(ItemID.Sunglasses);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
