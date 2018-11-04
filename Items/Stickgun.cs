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
			item.shootSpeed = 20f;
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
			Tooltip.SetDefault("Uses sticks as ammo\n90% chance to not consume ammo");
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
			item.knockBack = 4;
			item.value = 1000000;
			item.rare = 11;
			item.crit = 50;
			item.UseSound = SoundID.Item40;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 40f;
			item.autoReuse = true;
		}

		public override bool ConsumeAmmo(Player player) {
			return Main.rand.NextFloat() >= .9f;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
			Vector2 newSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
			speedX = newSpeed.X;
			speedY = newSpeed.Y;
			return true;
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

    public class StickgunBossSpawner : ModItem {
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Twitching Stickgun");
			Tooltip.SetDefault("'Imbued with the spark of life'");
		}

		public override void SetDefaults() {
			item.width = 80;
			item.height = 14;
			item.maxStack = 1;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 4;
			item.consumable = true;
            item.rare = 11;
		}

		public override bool CanUseItem(Player player) {
			return !NPC.AnyNPCs(mod.NPCType("Stickgun")) && !Main.dayTime;
		}

		public override bool UseItem(Player player) {
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Stickgun"));
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("EmotionalStickgun"));
            recipe.AddIngredient(ItemID.Nanites, 99);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
