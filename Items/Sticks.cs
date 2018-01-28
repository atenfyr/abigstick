using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace ABigStick.Items {
    public class Stick : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Stick");
        }

        public override void AutoStaticDefaults() {
            Main.projectileTexture[projectile.type] = ModLoader.GetTexture("ABigStick/Items/Stick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 4;
            projectile.aiStyle = 1;
            projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
            projectile.ranged = true;
        }
    }

    public class StickCr2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Shadestick");
        }

        public override void AutoStaticDefaults() {
            Main.projectileTexture[projectile.type] = ModLoader.GetTexture("ABigStick/Items/CrimsonStick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 4;
            projectile.aiStyle = 1;
            projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
            projectile.ranged = true;
        }

		public override void OnHitNPC(NPC target, int damage, float knockback, bool cri) {
		    target.AddBuff(BuffID.Ichor, 5 * 60);
		}
    }

    public class StickCo2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Ebonstick");
        }

        public override void AutoStaticDefaults() {
            Main.projectileTexture[projectile.type] = ModLoader.GetTexture("ABigStick/Items/CorruptionStick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 4;
            projectile.aiStyle = 1;
            projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
            projectile.ranged = true;
        }

		public override void OnHitNPC(NPC target, int damage, float knockback, bool cri) {
		    target.AddBuff(BuffID.CursedInferno, 5 * 60);
		}
    }

    public class StickH2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Pearlstick");
        }

        public override void AutoStaticDefaults() {
            Main.projectileTexture[projectile.type] = ModLoader.GetTexture("ABigStick/Items/HallowedStick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 4;
            projectile.aiStyle = 1;
            projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
            projectile.ranged = true;
        }

		public override void OnHitNPC(NPC target, int damage, float knockback, bool cri) {
		    target.AddBuff(BuffID.Slow, 5 * 60);
		}
    }

    public class StickBo2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Boreal Stick");
        }

        public override void AutoStaticDefaults() {
            Main.projectileTexture[projectile.type] = ModLoader.GetTexture("ABigStick/Items/BorealStick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 4;
            projectile.aiStyle = 1;
            projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
            projectile.ranged = true;
        }

		public override void OnHitNPC(NPC target, int damage, float knockback, bool cri) {
		    target.AddBuff(BuffID.Chilled, 5 * 60);
		}
    }

    public class StickL2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Luminite Stick");
        }

        public override void AutoStaticDefaults() {
            Main.projectileTexture[projectile.type] = ModLoader.GetTexture("ABigStick/Items/LuminiteStick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 4;
            projectile.aiStyle = 1;
            projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
            projectile.ranged = true;
        }

		public override void OnHitNPC(NPC target, int damage, float knockback, bool cri) {
		    projectile.damage = projectile.damage + 5;
		}
    }
    
    public class StickD2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Rainbow Stick");
        }

        public override void AutoStaticDefaults() {
            Main.projectileTexture[projectile.type] = ModLoader.GetTexture("ABigStick/Items/RainbowStickProjectile");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 4;
            projectile.aiStyle = 1;
            projectile.friendly = true;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
            projectile.ranged = true;
            projectile.penetrate = 999;
        }
    }

    public class StickM2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Greedy Stick");
        }

        public override void AutoStaticDefaults() {
            Main.projectileTexture[projectile.type] = ModLoader.GetTexture("ABigStick/Items/GreedyStick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 4;
            projectile.aiStyle = 1;
            projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
            projectile.ranged = true;
            projectile.penetrate = 3;
        }

    	public override void OnHitNPC(NPC target, int damage, float knockback, bool cri) {
            int value = Main.rand.Next(20, 200);
            
            if ((Main.rand.NextFloat() >= .45f) && target.type != NPCID.TargetDummy) {
                if (value >= 100) {
                    double partialValue = (double)value/(double)100;
                    int roundedValue = (int)Math.Floor(partialValue);
                    Item.NewItem(target.getRect(), ItemID.SilverCoin, roundedValue);
                    Item.NewItem(target.getRect(), ItemID.CopperCoin, (int)(partialValue-roundedValue));
                } else {
                    Item.NewItem(target.getRect(), ItemID.CopperCoin, value);
                }
            }
		}
    }

    public class StickK2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Spooky Stick");
        }

        public override void AutoStaticDefaults() {
            Main.projectileTexture[projectile.type] = ModLoader.GetTexture("ABigStick/Items/SpookyStick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 4;
            projectile.aiStyle = 1;
            projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
            projectile.ranged = true;
            projectile.penetrate = 3;
        }

    	public override void OnHitNPC(NPC target, int damage, float knockback, bool cri) {
            if (Main.rand.Next(1,3) == 1) {
                target.AddBuff(BuffID.Confused, 2 * 60);
            }
		}
    }

    public class StickAten2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Stick of Tears");
        }

        public override void AutoStaticDefaults() {
            Main.projectileTexture[projectile.type] = ModLoader.GetTexture("ABigStick/Items/StickofTears");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 4;
            projectile.aiStyle = 1;
            projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
            projectile.ranged = true;
            projectile.penetrate = 999;
        }

    	public override void OnHitNPC(NPC target, int damage, float knockback, bool cri) {
            target.AddBuff(mod.BuffType("Mourning"), 10 * 60);
		}

    	public override void OnHitPvp(Player target, int damage, bool cri) {
            target.AddBuff(mod.BuffType("Mourning"), 10 * 60);
		}

		public override void Kill(int timeLeft) {
            for (int i = 0; i <= 2; i++) {
                Dust.NewDust(projectile.position, 0, 0, 253, 0f, 0f, 0, new Color(78,94,176), 0.55f);
            }
        }
    }

    public class StickMoon2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Lunar Stick");
        }

        public override void AutoStaticDefaults() {
            Main.projectileTexture[projectile.type] = ModLoader.GetTexture("ABigStick/Items/LunarStick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 4;
            projectile.aiStyle = 1;
            projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
            projectile.ranged = true;
            projectile.penetrate = 999;
        }

		public override void Kill(int timeLeft) {
            for (int i = 0; i <= 2; i++) {
                Dust.NewDust(projectile.position, 0, 0, 1, 0f, 0f, 0, new Color(155, 155, 155), 0.75f);
            }
        }
    }

    public class StickItem : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Stick");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/Stick");
        }

        public override void SetDefaults() {
			item.damage = 3;
			item.ranged = true;
			item.width = 4;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 10;
            item.shoot = mod.ProjectileType("Stick");
            item.ammo = item.type;
            item.maxStack = 999;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 50);
            recipe.SetResult(this, 150);
            recipe.AddRecipe();
            ModRecipe recipe3 = new ModRecipe(mod);
			recipe3.AddIngredient(ItemID.PalmWood, 50);
            recipe3.SetResult(this, 150);
            recipe3.AddRecipe();
            ModRecipe recipe4 = new ModRecipe(mod);
			recipe4.AddIngredient(ItemID.RichMahogany, 50);
            recipe4.SetResult(this, 150);
            recipe4.AddRecipe();
        }
    }

    public class StickH : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Pearlstick");
            Tooltip.SetDefault("Inflicts Slow");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/HallowedStick");
        }

        public override void SetDefaults() {
			item.damage = 5;
			item.ranged = true;
			item.width = 4;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 10;
            item.shoot = mod.ProjectileType("StickH2");
            item.ammo = mod.ItemType("StickItem");
            item.maxStack = 999;
            item.rare = 4;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Pearlwood, 50);
            recipe.SetResult(this, 150);
            recipe.AddRecipe();
        }
    }

    public class StickCo : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Ebonstick");
            Tooltip.SetDefault("Inflicts Cursed Inferno");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/CorruptionStick");
        }

        public override void SetDefaults() {
			item.damage = 5;
			item.ranged = true;
			item.width = 4;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 100;
            item.shoot = mod.ProjectileType("StickCo2");
            item.ammo = mod.ItemType("StickItem");
            item.maxStack = 999;
            item.rare = 2;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ebonwood, 50);
            recipe.SetResult(this, 150);
            recipe.AddRecipe();
        }
    }

    public class StickCr : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Shadestick");
            Tooltip.SetDefault("Inflicts Ichor");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/CrimsonStick");
        }

        public override void SetDefaults() {
			item.damage = 7;
			item.ranged = true;
			item.width = 4;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 100;
            item.shoot = mod.ProjectileType("StickCr2");
            item.ammo = mod.ItemType("StickItem");
            item.maxStack = 999;
            item.rare = 2;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Shadewood, 50);
            recipe.SetResult(this, 150);
            recipe.AddRecipe();
        }
    }

    public class StickBo : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Boreal Stick");
            Tooltip.SetDefault("Inflicts Chilled");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/BorealStick");
        }

        public override void SetDefaults() {
			item.damage = 3;
			item.ranged = true;
			item.width = 4;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 100;
            item.shoot = mod.ProjectileType("StickBo2");
            item.ammo = mod.ItemType("StickItem");
            item.maxStack = 999;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BorealWood, 50);
            recipe.SetResult(this, 150);
            recipe.AddRecipe();
        }
    }

    public class StickL : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Luminite Stick");
            Tooltip.SetDefault("Increases in damage the more targets it pierces through\n'This is irrational.'");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/LuminiteStick");
        }

        public override void SetDefaults() {
			item.damage = 15;
			item.ranged = true;
			item.width = 4;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 4f;
			item.value = 0;
            item.rare = 9;
            item.shoot = mod.ProjectileType("StickL2");
            item.ammo = mod.ItemType("StickItem");
            item.crit = 30;            
            item.maxStack = 999;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 1);
            recipe.SetResult(this, 333);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.AddRecipe();
        }
    }
    

    public class StickD : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Rainbow Stick");
            Tooltip.SetDefault("'Physics? What's that?'");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 7));
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/RainbowStickItem");
        }

        public override void SetDefaults() {
			item.damage = 9999;
			item.ranged = true;
			item.width = 4;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 4f;
			item.value = 9999999;
            item.rare = 11;
            item.expert = true;
            item.shoot = mod.ProjectileType("StickD2");
            item.ammo = mod.ItemType("StickItem");
            item.crit = 30;
            item.maxStack = 999;
        }
    }

    public class StickM : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Greedy Stick");
            Tooltip.SetDefault("45% chance to steal money on impact");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/GreedyStick");
        }

        public override void SetDefaults() {
			item.damage = 7;
			item.ranged = true;
			item.width = 4;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 0f;
			item.value = 200;
            item.shoot = mod.ProjectileType("StickM2");
            item.ammo = mod.ItemType("StickItem");
            item.crit = 20;
            item.maxStack = 999;
        }
    }

    public class StickK : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Spooky Stick");
            Tooltip.SetDefault("33% chance to inflict Confused");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/SpookyStick");
        }

        public override void SetDefaults() {
			item.damage = 4;
			item.ranged = true;
			item.width = 4;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 0f;
			item.value = 200;
            item.shoot = mod.ProjectileType("StickK2");
            item.ammo = mod.ItemType("StickItem");
            item.maxStack = 999;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpookyWood, 50);
            recipe.SetResult(this, 100);
            recipe.AddRecipe();
        }
    }

    public class StickAten : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Stick of Tears");
            Tooltip.SetDefault("'Forged from their final tears'");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/StickofTears");
        }

        public override void SetDefaults() {
			item.damage = 35;
			item.ranged = true;
			item.width = 4;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 2f;
			item.value = 1000;
            item.shoot = mod.ProjectileType("StickAten2");
            item.ammo = mod.ItemType("StickItem");
            item.maxStack = 999;
            item.rare = 9;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("LastTears"), 25);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 200);
            recipe.AddRecipe();
        }
    }

    public class StickMoon : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Lunar Stick");
            Tooltip.SetDefault("'Raw power resonates throughout the stick'");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/LunarStick");
        }

        public override void SetDefaults() {
			item.damage = 55;
			item.ranged = true;
			item.width = 4;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 2f;
			item.value = 12500;
            item.shoot = mod.ProjectileType("StickMoon2");
            item.ammo = mod.ItemType("StickItem");
            item.maxStack = 999;
            item.rare = 11;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("StickItem"), 20);
			recipe.AddIngredient(mod.ItemType("MoonTears"), 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 20);
            recipe.AddRecipe();
        }
    }

	public class Drops : GlobalNPC {
		public override void NPCLoot(NPC npc) {
            int count = Main.rand.Next(5, 10);
            if (Main.rand.NextBool(Main.expertMode ? 2 : 1, 5)) {
                count = count * 2;
            }
            if (NPC.downedTowerVortex) {
                if (((npc.type >= 212 && npc.type <= 216) || npc.type == 229 || npc.type == 252)) { // all pirates and parrots
                    if (Main.rand.NextFloat() >= .25f) {
                        Item.NewItem(npc.getRect(), mod.ItemType("StickM"), count);
                    }
                } else if (npc.type == 491) { // pirate ship
                    Item.NewItem(npc.getRect(), mod.ItemType("StickM"), count*2);
                }
            }

            if (npc.type == 398) { // moon lord's core
                Item.NewItem(npc.getRect(), mod.ItemType("MoonTears"), Main.rand.Next(5, 8));
            } else if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].GetModPlayer<ABigPlayer>(mod).hasTearNet) {
                if (Main.rand.NextFloat() <= .75f && npc.type != 401 && npc.lifeMax > 5) { // moon lord's leech can't drop tears, and neither can critters
                    Item.NewItem(npc.getRect(), mod.ItemType("LastTears"), Main.rand.Next(1, 3));
                }
            }
		}
    }

    public class Drops2 : GlobalItem {
        public override void OpenVanillaBag(string context, Player player, int arg) {
            if (context == "bossBag" && arg == 3332 && (Main.rand.Next(1,20) == 10)) { // moon lord
                player.QuickSpawnItem(mod.ItemType("EmotionalStickgun"), 1);
            } else if (context == "bossBag" && arg == 3860 && (Main.rand.Next(1,40) == 20)) { // betsy
                player.QuickSpawnItem(mod.ItemType("EmotionalStickgun"), 1);
            } else if (context == "bossBag" && arg >= 3325 && (Main.rand.Next(1,100) == 50)) { // any hardmode boss
                player.QuickSpawnItem(mod.ItemType("EmotionalStickgun"), 1);
            }
        }
    }
}