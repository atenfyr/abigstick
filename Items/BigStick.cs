using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ABigStick.Items
{
	public class BigStick : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Big Stick");
		}

		public override void SetDefaults() {
			item.damage = 90;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 100;
			item.value = 0;
			item.rare = 10;
			item.crit = 30;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 13);
			recipe.AddIngredient(ItemID.Wood, 100);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
