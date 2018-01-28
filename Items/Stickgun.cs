using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;

namespace ABigStick.Items {
	public class Stickgun : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Stickgun");
			Tooltip.SetDefault("Uses sticks as ammo\n70% chance to not consume ammo");
		}

		public override void SetDefaults() {
			item.damage = 80;
			item.ranged = true;
			item.width = 40;
			item.height = 7;
			item.maxStack = 1;
			item.useTime = 3;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 100000;
			item.rare = 10;
			item.crit = 50;
			item.UseSound = SoundID.Item36;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 200f;
			item.shoot = 10;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Phantasm, 1);
			recipe.AddIngredient(ItemID.FragmentVortex, 10);
			recipe.AddIngredient(ItemID.Wood, 100);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.VortexBeater, 1);
			recipe2.AddIngredient(ItemID.FragmentVortex, 10);
			recipe2.AddIngredient(ItemID.Wood, 100);
			recipe2.AddTile(TileID.LunarCraftingStation);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}

		public override bool ConsumeAmmo(Player player) {
			return Main.rand.NextFloat() >= .70f;
		}
	}

	public class EmotionalStickgun : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Clockwork Stickgun");
			Tooltip.SetDefault("90% chance to not consume ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/ClockworkStickgun");
        }


		public override void SetDefaults() {
			item.damage = 135;
			item.ranged = true;
			item.width = 40;
			item.height = 7;
			item.maxStack = 1;
			item.useTime = 0;
			item.useAnimation = 5;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 1000000;
			item.rare = 11;
			item.crit = 50;
			item.UseSound = SoundID.Item40;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 1200000;
			item.shoot = 10;
			item.autoReuse = true;
		}

		public override bool ConsumeAmmo(Player player) {
			return Main.rand.NextFloat() >= .9f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Stickgun"));
			recipe.AddIngredient(ItemID.SDMG);
			recipe.AddIngredient(mod.ItemType("LastTears"), 25);
			recipe.AddIngredient(ItemID.Cog, 25);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
