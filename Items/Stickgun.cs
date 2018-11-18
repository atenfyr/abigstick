using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;

namespace ABigStick.Items {
    // Backwards compatibility stickgun
    public class Stickgun : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("IOU a Clockwork Stickgun");
			Tooltip.SetDefault("<right> to obtain a Clockwork Stickgun");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/1/Crit");
        }

		public override void SetDefaults() {
			item.value = 0;
			item.rare = 10;
            item.maxStack = 1;
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void RightClick(Player player) {
			player.QuickSpawnItem(mod.ItemType("EmotionalStickgun"));
		}
    }

    // Level -1 Stickgun (DPS-based)
	public class WoodenStickgun : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Wooden Stickgun");
			Tooltip.SetDefault("Uses sticks as ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/-1/DPS");
        }

		public override void SetDefaults() {
			item.damage = 9;
			item.ranged = true;
			item.width = 25;
			item.height = 13;
			item.maxStack = 1;
			item.useTime = 23;
			item.useAnimation = 23;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 100;
			item.rare = 0;
			item.crit = 5;
			item.UseSound = SoundID.Item40;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

    // Level -1 Stickgun (Crit-based)
	public class WoodenStickSniper : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Wooden Stickrifle");
			Tooltip.SetDefault("Uses sticks as ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/-1/Crit");
        }

		public override void SetDefaults() {
			item.damage = 13;
			item.ranged = true;
			item.width = 35;
			item.height = 8;
			item.maxStack = 1;
			item.useTime = 41;
			item.useAnimation = 41;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 100;
			item.rare = 0;
			item.crit = 30;
			item.UseSound = SoundID.Item36;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

    // Level 0 Stickgun (DPS-based)
	public class Lvl0Stickgun : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Demonite Stickgun");
			Tooltip.SetDefault("Uses sticks as ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/0/DPS");
        }

		public override void SetDefaults() {
			item.damage = 25;
			item.ranged = true;
			item.width = 26;
			item.height = 13;
			item.maxStack = 1;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 100;
			item.rare = 1;
			item.crit = 5;
			item.UseSound = SoundID.Item40;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteBar, 15);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgrade = new ModRecipe(mod);
            upgrade.AddIngredient(mod.ItemType("WoodenStickgun"));
            upgrade.AddIngredient(ItemID.DemoniteBar, 14);
			upgrade.AddTile(TileID.Anvils);
			upgrade.SetResult(this);
			upgrade.AddRecipe();
		}
	}

    // Level 0 Stickgun (Crit-based)
	public class Lvl0StickSniper : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Demonite Stickrifle");
			Tooltip.SetDefault("Uses sticks as ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/0/Crit");
        }

		public override void SetDefaults() {
			item.damage = 47;
			item.ranged = true;
			item.width = 35;
			item.height = 8;
			item.maxStack = 1;
			item.useTime = 39;
			item.useAnimation = 39;
			item.useStyle = 5;
			item.knockBack = 3;
			item.value = 100;
			item.rare = 1;
			item.crit = 35;
			item.UseSound = SoundID.Item36;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteBar, 15);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgrade = new ModRecipe(mod);
            upgrade.AddIngredient(mod.ItemType("WoodenStickSniper"));
            upgrade.AddIngredient(ItemID.DemoniteBar, 14);
			upgrade.AddTile(TileID.Anvils);
			upgrade.SetResult(this);
			upgrade.AddRecipe();
		}
	}

    // Level 0 Stickgun (DPS-based)
	public class Lvl0StickgunC : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Crimtane Stickgun");
			Tooltip.SetDefault("Uses sticks as ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/0/DPS_C");
        }

		public override void SetDefaults() {
			item.damage = 27;
			item.ranged = true;
			item.width = 26;
			item.height = 13;
			item.maxStack = 1;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 100;
			item.rare = 1;
			item.crit = 5;
			item.UseSound = SoundID.Item40;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimtaneBar, 15);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgrade = new ModRecipe(mod);
            upgrade.AddIngredient(mod.ItemType("WoodenStickgun"));
            upgrade.AddIngredient(ItemID.CrimtaneBar, 14);
			upgrade.AddTile(TileID.Anvils);
			upgrade.SetResult(this);
			upgrade.AddRecipe();
		}
	}

    // Level 0 Stickgun (Crit-based)
	public class Lvl0StickSniperC : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Crimtane Stickrifle");
			Tooltip.SetDefault("Uses sticks as ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/0/Crit_C");
        }

		public override void SetDefaults() {
			item.damage = 47;
			item.ranged = true;
			item.width = 35;
			item.height = 8;
			item.maxStack = 1;
			item.useTime = 39;
			item.useAnimation = 39;
			item.useStyle = 5;
			item.knockBack = 3;
			item.value = 100;
			item.rare = 1;
			item.crit = 35;
			item.UseSound = SoundID.Item36;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimtaneBar, 15);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgrade = new ModRecipe(mod);
            upgrade.AddIngredient(mod.ItemType("WoodenStickSniper"));
            upgrade.AddIngredient(ItemID.CrimtaneBar, 14);
			upgrade.AddTile(TileID.Anvils);
			upgrade.SetResult(this);
			upgrade.AddRecipe();
		}
	}
    
    // Level 1 Stickgun (DPS-based)
	public class Lvl1Stickgun : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Hellstone Stickgun");
			Tooltip.SetDefault("Uses sticks as ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/1/DPS");
        }

		public override void SetDefaults() {
			item.damage = 32;
			item.ranged = true;
			item.width = 26;
			item.height = 13;
			item.maxStack = 1;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 3000;
			item.rare = 3;
			item.crit = 5;
			item.UseSound = SoundID.Item40;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgrade = new ModRecipe(mod);
            upgrade.AddIngredient(mod.ItemType("Lvl0Stickgun"));
            upgrade.AddIngredient(ItemID.HellstoneBar, 14);
			upgrade.AddTile(TileID.Anvils);
			upgrade.SetResult(this);
			upgrade.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgrade2 = new ModRecipe(mod);
            upgrade2.AddIngredient(mod.ItemType("Lvl0StickgunC"));
            upgrade2.AddIngredient(ItemID.HellstoneBar, 14);
			upgrade2.AddTile(TileID.Anvils);
			upgrade2.SetResult(this);
			upgrade2.AddRecipe();
		}
	}

    // Level 1 Stickgun (Crit-based)
	public class StickSniper : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Hellstone Stickrifle");
			Tooltip.SetDefault("Uses sticks as ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/1/Crit");
        }

		public override void SetDefaults() {
			item.damage = 55;
			item.ranged = true;
			item.width = 35;
			item.height = 8;
			item.maxStack = 1;
			item.useTime = 36;
			item.useAnimation = 36;
			item.useStyle = 5;
			item.knockBack = 4;
			item.value = 3000;
			item.rare = 3;
			item.crit = 30;
			item.UseSound = SoundID.Item36;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
            // Making a brand new stickgun
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgrade = new ModRecipe(mod);
            upgrade.AddIngredient(mod.ItemType("Lvl0StickSniper"));
            upgrade.AddIngredient(ItemID.HellstoneBar, 14);
			upgrade.AddTile(TileID.Anvils);
			upgrade.SetResult(this);
			upgrade.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgrade2 = new ModRecipe(mod);
            upgrade2.AddIngredient(mod.ItemType("Lvl0StickSniperC"));
            upgrade2.AddIngredient(ItemID.HellstoneBar, 14);
			upgrade2.AddTile(TileID.Anvils);
			upgrade2.SetResult(this);
			upgrade2.AddRecipe();
		}
	}

    // Level 2 Stickgun (Adamantite, DPS-based)
	public class Lvl2StickgunA : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Adamantite Stickgun");
			Tooltip.SetDefault("Uses sticks as ammo\n25% chance to not consume ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/2/DPS_A");
        }

		public override void SetDefaults() {
			item.damage = 45;
			item.ranged = true;
			item.width = 30;
			item.height = 15;
			item.maxStack = 1;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 7000;
			item.rare = 4;
			item.crit = 5;
			item.UseSound = SoundID.Item40;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
            // Making a brand new stickgun
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AdamantiteBar, 12);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgrade = new ModRecipe(mod);
            upgrade.AddIngredient(mod.ItemType("Lvl1Stickgun"));
            upgrade.AddIngredient(ItemID.AdamantiteBar, 11);
			upgrade.AddTile(TileID.MythrilAnvil);
			upgrade.SetResult(this);
			upgrade.AddRecipe();
		}

		public override bool ConsumeAmmo(Player player) {
			return Main.rand.NextFloat() >= .25f;
		}
	}

    // Level 2 Stickgun (Titanium, DPS-based)
	public class Lvl2StickgunT : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Titanium Stickgun");
			Tooltip.SetDefault("Uses sticks as ammo\n25% chance to not consume ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/2/DPS_T");
        }

		public override void SetDefaults() {
			item.damage = 47;
			item.ranged = true;
			item.width = 30;
			item.height = 15;
			item.maxStack = 1;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 7000;
			item.rare = 4;
			item.crit = 5;
			item.UseSound = SoundID.Item40;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
            // Making a brand new stickgun
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TitaniumBar, 12);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgrade = new ModRecipe(mod);
            upgrade.AddIngredient(mod.ItemType("Lvl1Stickgun"));
            upgrade.AddIngredient(ItemID.TitaniumBar, 11);
			upgrade.AddTile(TileID.MythrilAnvil);
			upgrade.SetResult(this);
			upgrade.AddRecipe();
		}

		public override bool ConsumeAmmo(Player player) {
			return Main.rand.NextFloat() >= .25f;
		}
	}

    // Level 2 Stickgun (Adamantite, crit-based)
	public class Lvl2StickSniperA : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Adamantite Stickrifle");
			Tooltip.SetDefault("Uses sticks as ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/2/Crit_A");
        }

		public override void SetDefaults() {
			item.damage = 72;
			item.ranged = true;
			item.width = 39;
			item.height = 8;
			item.maxStack = 1;
			item.useTime = 34;
			item.useAnimation = 34;
			item.useStyle = 5;
			item.knockBack = 5;
			item.value = 7000;
			item.rare = 3;
			item.crit = 35;
			item.UseSound = SoundID.Item36;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
            // Making a brand new stickgun
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AdamantiteBar, 12);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgrade = new ModRecipe(mod);
            upgrade.AddIngredient(mod.ItemType("StickSniper"));
            upgrade.AddIngredient(ItemID.AdamantiteBar, 11);
			upgrade.AddTile(TileID.MythrilAnvil);
			upgrade.SetResult(this);
			upgrade.AddRecipe();
		}
	}

    // Level 2 Stickgun (Titanium, crit-based)
	public class Lvl2StickSniperT : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Titanium Stickrifle");
			Tooltip.SetDefault("Uses sticks as ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/2/Crit_T");
        }

		public override void SetDefaults() {
			item.damage = 75;
			item.ranged = true;
			item.width = 39;
			item.height = 8;
			item.maxStack = 1;
			item.useTime = 34;
			item.useAnimation = 34;
			item.useStyle = 5;
			item.knockBack = 5;
			item.value = 7000;
			item.rare = 3;
			item.crit = 35;
			item.UseSound = SoundID.Item36;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
            // Making a brand new stickgun
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TitaniumBar, 12);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgrade = new ModRecipe(mod);
            upgrade.AddIngredient(mod.ItemType("StickSniper"));
            upgrade.AddIngredient(ItemID.TitaniumBar, 11);
			upgrade.AddTile(TileID.MythrilAnvil);
			upgrade.SetResult(this);
			upgrade.AddRecipe();
		}
	}

    // Level 3 Stickgun (DPS-based)
	public class Lvl3Stickgun : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Autotrophic Stickgun");
			Tooltip.SetDefault("Uses sticks as ammo\n35% chance to not consume ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/3/DPS");
        }

		public override void SetDefaults() {
			item.damage = 55;
			item.ranged = true;
			item.width = 33;
			item.height = 15;
			item.maxStack = 1;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 13000;
			item.rare = 7;
			item.crit = 5;
			item.UseSound = SoundID.Item40;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
            // Making a brand new stickgun
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 12);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgradeA = new ModRecipe(mod);
            upgradeA.AddIngredient(mod.ItemType("Lvl2StickgunA"));
            upgradeA.AddIngredient(ItemID.ChlorophyteBar, 11);
			upgradeA.AddTile(TileID.MythrilAnvil);
			upgradeA.SetResult(this);
			upgradeA.AddRecipe();

            ModRecipe upgradeT = new ModRecipe(mod);
            upgradeT.AddIngredient(mod.ItemType("Lvl2StickgunT"));
            upgradeT.AddIngredient(ItemID.ChlorophyteBar, 11);
			upgradeT.AddTile(TileID.MythrilAnvil);
			upgradeT.SetResult(this);
			upgradeT.AddRecipe();
		}

		public override bool ConsumeAmmo(Player player) {
			return Main.rand.NextFloat() >= .35f;
		}
	}

    // Level 3 Stickgun (Crit-based)
	public class Lvl3StickSniper : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Autotrophic Stickrifle");
			Tooltip.SetDefault("Uses sticks as ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/3/Crit");
        }

		public override void SetDefaults() {
			item.damage = 95;
			item.ranged = true;
			item.width = 42;
			item.height = 9;
			item.maxStack = 1;
			item.useTime = 31;
			item.useAnimation = 31;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 13000;
			item.rare = 7;
			item.crit = 50;
			item.UseSound = SoundID.Item36;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
            // Making a brand new stickgun
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 12);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgradeA = new ModRecipe(mod);
            upgradeA.AddIngredient(mod.ItemType("Lvl2StickSniperA"));
            upgradeA.AddIngredient(ItemID.ChlorophyteBar, 11);
			upgradeA.AddTile(TileID.MythrilAnvil);
			upgradeA.SetResult(this);
			upgradeA.AddRecipe();

            ModRecipe upgradeT = new ModRecipe(mod);
            upgradeT.AddIngredient(mod.ItemType("Lvl2StickSniperT"));
            upgradeT.AddIngredient(ItemID.ChlorophyteBar, 11);
			upgradeT.AddTile(TileID.MythrilAnvil);
			upgradeT.SetResult(this);
			upgradeT.AddRecipe();
		}
	}

    // Level 4 Stickgun (DPS-based)
	public class Lvl4Stickgun : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Spectre Stickgun");
			Tooltip.SetDefault("Uses sticks as ammo\n45% chance to not consume ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/4/DPS");
        }

		public override void SetDefaults() {
			item.damage = 70;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.maxStack = 1;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 17000;
			item.rare = 8;
			item.crit = 5;
			item.UseSound = SoundID.Item40;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
            // Making a brand new stickgun
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SpectreBar, 12);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgrade = new ModRecipe(mod);
            upgrade.AddIngredient(mod.ItemType("Lvl3Stickgun"));
            upgrade.AddIngredient(ItemID.SpectreBar, 11);
			upgrade.AddTile(TileID.MythrilAnvil);
			upgrade.SetResult(this);
			upgrade.AddRecipe();
		}

		public override bool ConsumeAmmo(Player player) {
			return Main.rand.NextFloat() >= .45f;
		}
	}

    // Level 4 Stickgun (Crit-based)
	public class Lvl4StickSniper : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Spectre Stickrifle");
			Tooltip.SetDefault("Uses sticks as ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/4/Crit");
        }

		public override void SetDefaults() {
			item.damage = 135;
			item.ranged = true;
			item.width = 48;
			item.height = 12;
			item.maxStack = 1;
			item.useTime = 28;
			item.useAnimation = 28;
			item.useStyle = 5;
			item.knockBack = 7;
			item.value = 17000;
			item.rare = 8;
			item.crit = 50;
			item.UseSound = SoundID.Item36;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
            // Making a brand new stickgun
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SpectreBar, 12);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgrade = new ModRecipe(mod);
            upgrade.AddIngredient(mod.ItemType("Lvl3StickSniper"));
            upgrade.AddIngredient(ItemID.SpectreBar, 11);
			upgrade.AddTile(TileID.MythrilAnvil);
			upgrade.SetResult(this);
			upgrade.AddRecipe();
		}
	}

    // Level 5 Stickgun (DPS-based)
	public class Lvl5Stickgun : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Lunar Stickgun");
			Tooltip.SetDefault("Uses sticks as ammo\n55% chance to not consume ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/5/DPS");
        }

		public override void SetDefaults() {
			item.damage = 75;
			item.ranged = true;
			item.width = 47;
			item.height = 21;
			item.maxStack = 1;
			item.useTime = 6;
			item.useAnimation = 6;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 2500;
			item.rare = 10;
			item.crit = 5;
			item.UseSound = SoundID.Item40;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
            // Making a brand new stickgun
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentVortex, 28);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgrade = new ModRecipe(mod);
            upgrade.AddIngredient(mod.ItemType("Lvl4Stickgun"));
            upgrade.AddIngredient(ItemID.FragmentVortex, 27);
			upgrade.AddTile(TileID.LunarCraftingStation);
			upgrade.SetResult(this);
			upgrade.AddRecipe();
		}

		public override bool ConsumeAmmo(Player player) {
			return Main.rand.NextFloat() >= .55f;
		}
	}

    // Level 5 Stickgun (Crit-based)
	public class Lvl5StickSniper : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Lunar Stickrifle");
			Tooltip.SetDefault("Uses sticks as ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/5/Crit");
        }

		public override void SetDefaults() {
			item.damage = 185;
			item.ranged = true;
			item.width = 48;
			item.height = 13;
			item.maxStack = 1;
			item.useTime = 23;
			item.useAnimation = 23;
			item.useStyle = 5;
			item.knockBack = 8;
			item.value = 17000;
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
            // Making a brand new stickgun
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentVortex, 28);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();

            // Upgrading from previous tier
            ModRecipe upgrade = new ModRecipe(mod);
            upgrade.AddIngredient(mod.ItemType("Lvl4StickSniper"));
            upgrade.AddIngredient(ItemID.FragmentVortex, 27);
			upgrade.AddTile(TileID.LunarCraftingStation);
			upgrade.SetResult(this);
			upgrade.AddRecipe();
		}
	}

    // Level 6 Stickgun (DPS-based)
	public class EmotionalStickgun : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Clockwork Stickgun");
			Tooltip.SetDefault("Uses sticks as ammo\n70% chance to not consume ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/6/DPS");
        }

		public override void SetDefaults() {
			item.damage = 95;
			item.ranged = true;
			item.width = 53;
			item.height = 22;
			item.maxStack = 1;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 5;
			item.knockBack = 4;
			item.value = 500000;
			item.rare = 11;
			item.crit = 15;
			item.UseSound = SoundID.Item40;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 40f;
			item.autoReuse = true;
		}

		public override bool ConsumeAmmo(Player player) {
			return Main.rand.NextFloat() >= .70f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Phantasm, 1);
			recipe.AddIngredient(ItemID.LunarBar, 5);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.VortexBeater, 1);
			recipe2.AddIngredient(ItemID.LunarBar, 5);
			recipe2.AddIngredient(ItemID.Wood, 50);
			recipe2.AddTile(TileID.LunarCraftingStation);
			recipe2.SetResult(this);
			recipe2.AddRecipe();

            ModRecipe upgrade = new ModRecipe(mod);
            upgrade.AddIngredient(mod.ItemType("Lvl5Stickgun"));
			upgrade.AddIngredient(ItemID.LunarBar, 5);
			upgrade.AddTile(TileID.LunarCraftingStation);
			upgrade.SetResult(this);
			upgrade.AddRecipe();
		}
	}

    // Level 6 Stickgun (Crit-based)
	public class EmotionalStickRifle : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Clockwork Stickrifle");
			Tooltip.SetDefault("Uses sticks as ammo");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/6/Crit");
        }

		public override void SetDefaults() {
			item.damage = 255;
			item.ranged = true;
			item.width = 52;
			item.height = 15;
			item.maxStack = 1;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 9;
			item.value = 500000;
			item.rare = 11;
			item.crit = 50;
			item.UseSound = SoundID.Item36;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Stick");
			item.useAmmo = mod.ItemType("StickItem");
			item.shootSpeed = 40f;
			item.autoReuse = true;
		}
        
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Phantasm, 1);
			recipe.AddIngredient(ItemID.LunarBar, 5);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.VortexBeater, 1);
			recipe2.AddIngredient(ItemID.LunarBar, 5);
			recipe2.AddIngredient(ItemID.Wood, 50);
			recipe2.AddTile(TileID.LunarCraftingStation);
			recipe2.SetResult(this);
			recipe2.AddRecipe();

            ModRecipe upgrade = new ModRecipe(mod);
            upgrade.AddIngredient(mod.ItemType("Lvl5StickSniper"));
			upgrade.AddIngredient(ItemID.LunarBar, 5);
			upgrade.AddTile(TileID.LunarCraftingStation);
			upgrade.SetResult(this);
			upgrade.AddRecipe();
		}
	}

    public class StickgunBossSpawner : ModItem {
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Twitching Stickgun");
			Tooltip.SetDefault("'Imbued with the spark of life'");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/6/Crit");
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
			return !NPC.AnyNPCs(mod.NPCType("SentientStickgun")) && !Main.dayTime;
		}

		public override bool UseItem(Player player) {
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("SentientStickgun"));
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
