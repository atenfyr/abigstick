using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace ABigStick.Items {
    public class MiniStick : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Stick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 20;
            projectile.aiStyle = 1;
            projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
            projectile.ranged = true;
        }
    }

    public class MiniStickCr2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Shadestick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 20;
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

    public class MiniStickCo2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Ebonstick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 20;
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

    public class MiniStickH2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Pearlstick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 20;
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

    public class MiniStickBo2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Boreal Stick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 20;
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

    public class MiniStickL2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Luminite Stick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 20;
            projectile.aiStyle = 1;
            projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
            projectile.ranged = true;
            projectile.penetrate = 999;
        }

		public override void OnHitNPC(NPC target, int damage, float knockback, bool cri) {
		    projectile.damage = projectile.damage + 5;
		}
    }
    
    public class MiniStickD2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Rainbow Stick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 20;
            projectile.aiStyle = 1;
            projectile.friendly = true;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
            projectile.ranged = true;
            projectile.penetrate = 999;
        }
    }

    public class MiniStickM2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Greedy Stick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 20;
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

    public class MiniStick2 : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Stick");
		}

        public override void SetDefaults() {
			item.damage = 3;
			item.ranged = true;
			item.width = 20;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 10;
            item.shoot = mod.ProjectileType("MiniStick");
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

    public class MiniStickH : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Pearlstick");
            Tooltip.SetDefault("Inflicts Slow");
		}

        public override void SetDefaults() {
			item.damage = 5;
			item.ranged = true;
			item.width = 20;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 10;
            item.shoot = mod.ProjectileType("MiniStickH2");
            item.ammo = mod.ItemType("MiniStick2");
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

    public class MiniStickCo : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Ebonstick");
            Tooltip.SetDefault("Inflicts Cursed Inferno");
		}

        public override void SetDefaults() {
			item.damage = 5;
			item.ranged = true;
			item.width = 20;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 100;
            item.shoot = mod.ProjectileType("MiniStickCo2");
            item.ammo = mod.ItemType("MiniStick2");
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

    public class MiniStickCr : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Shadestick");
            Tooltip.SetDefault("Inflicts Ichor");
		}

        public override void SetDefaults() {
			item.damage = 7;
			item.ranged = true;
			item.width = 20;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 100;
            item.shoot = mod.ProjectileType("MiniStickCr2");
            item.ammo = mod.ItemType("MiniStick2");
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

    public class MiniStickBo : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Boreal Stick");
            Tooltip.SetDefault("Inflicts Chilled");
		}

        public override void SetDefaults() {
			item.damage = 3;
			item.ranged = true;
			item.width = 20;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 100;
            item.shoot = mod.ProjectileType("MiniStickBo2");
            item.ammo = mod.ItemType("MiniStick2");
            item.maxStack = 999;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BorealWood, 50);
            recipe.SetResult(this, 150);
            recipe.AddRecipe();
        }
    }

    public class MiniStickL : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Luminite Stick");
            Tooltip.SetDefault("Increases in damage the more targets it pierces through\n'This is irrational.'");
		}

        public override void SetDefaults() {
			item.damage = 15;
			item.ranged = true;
			item.width = 20;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 4f;
			item.value = 0;
            item.rare = 9;
            item.shoot = mod.ProjectileType("MiniStickL2");
            item.ammo = mod.ItemType("MiniStick2");
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
    

    public class MiniStickD : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Rainbow Stick");
            Tooltip.SetDefault("'Physics? What's that?'");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 7));
		}

        public override void SetDefaults() {
			item.damage = 9999;
			item.ranged = true;
			item.width = 20;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 4f;
			item.value = 9999999;
            item.rare = 11;
            item.expert = true;
            item.shoot = mod.ProjectileType("MiniStickD2");
            item.ammo = mod.ItemType("MiniStick2");
            item.crit = 30;
            item.maxStack = 999;
        }
    }

    public class MiniStickM : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Greedy Stick");
            Tooltip.SetDefault("45% chance to steal money on impact");
		}

        public override void SetDefaults() {
			item.damage = 7;
			item.ranged = true;
			item.width = 20;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 0f;
			item.value = 200;
            item.shoot = mod.ProjectileType("MiniStickM2");
            item.ammo = mod.ItemType("MiniStick2");
            item.crit = 50;
            item.maxStack = 999;
        }
    }

	public class PirateStickDrop : GlobalNPC {
		public override void NPCLoot(NPC npc) {
            int count = Main.rand.Next(5, 10);
            if(Main.rand.NextBool(Main.expertMode ? 2 : 1, 5)) {
                count = count * 2;
            }
            if (NPC.downedTowerVortex) {
                if (((npc.type >= 212 && npc.type <= 216) || npc.type == 229 || npc.type == 252)) { // all pirates and parrots
                    if (Main.rand.NextFloat() >= .25f) {
                        Item.NewItem(npc.getRect(), mod.ItemType("MiniStickM"), count);
                    }
                } else if (npc.type == 491) { // pirate ship
                    Item.NewItem(npc.getRect(), mod.ItemType("MiniStickM"), count*2);
                }
            }
		}
    }   
}