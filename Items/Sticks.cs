using System;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ABigStick.Items {
    public class Stick : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Stick");
        }

        public override void AutoStaticDefaults() {
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/Stick");
        }

        public override void SetDefaults() {
            Projectile.width = 20;
            Projectile.height = 4;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 1;
        }
    }

    public class HighVelocityStick : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("High Velocity Stick");
        }

        public override void AutoStaticDefaults() {
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/HighVelocityStick_Projectile");
        }

        public override void SetDefaults() {
            Projectile.width = 20;
            Projectile.height = 4;
            Projectile.aiStyle = -1;
            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 1;
            Projectile.extraUpdates = 3;
        }

        public override void AI() {
            Projectile.rotation = (float)(Math.Atan2(Projectile.velocity.Y, Projectile.velocity.X));
        }
    }

    public class PenetratingStick : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Meteorite Stick");
        }

        public override void AutoStaticDefaults() {
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/MeteoriteStick");
        }

        public override void SetDefaults() {
            Projectile.width = 20;
            Projectile.height = 4;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 5;
        }
    }

    public class StickCr2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Shadestick");
        }

        public override void AutoStaticDefaults() {
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/CrimsonStick");
        }

        public override void SetDefaults() {
            Projectile.width = 20;
            Projectile.height = 4;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 1;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool cri) {
            target.AddBuff(BuffID.Ichor, 3 * 60);
        }
    }

    public class StickCo2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Ebonstick");
        }

        public override void AutoStaticDefaults() {
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/CorruptionStick");
        }

        public override void SetDefaults() {
            Projectile.width = 20;
            Projectile.height = 4;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 1;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool cri) {
            target.AddBuff(BuffID.CursedInferno, 3 * 60);
        }
    }

    public class StickH2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Pearlstick");
        }

        public override void AutoStaticDefaults() {
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/HallowedStick_Projectile");
        }

        public override void SetDefaults() {
            Projectile.width = 20;
            Projectile.height = 4;
            Projectile.aiStyle = -1;
            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 1;
            Projectile.extraUpdates = 1;
        }

        public override void AI() {
            Lighting.AddLight(Projectile.position, 1f, 1f, 1f);
            Projectile.rotation = (float)(Math.Atan2(Projectile.velocity.Y, Projectile.velocity.X));
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
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/BorealStick");
        }

        public override void SetDefaults() {
            Projectile.width = 20;
            Projectile.height = 4;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 1;
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
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/LuminiteStick");
        }

        public override void SetDefaults() {
            Projectile.width = 20;
            Projectile.height = 4;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 999;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool cri) {
            Projectile.damage = Projectile.damage + 5;
        }
    }
    
    public class StickD2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Rainbow Stick");
        }

        public override void AutoStaticDefaults() {
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/RainbowStickProjectile");
        }

        public override void SetDefaults() {
            Projectile.width = 20;
            Projectile.height = 4;
            Projectile.aiStyle = -1;
            Projectile.friendly = true;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.extraUpdates = 7;
            Projectile.penetrate = 999;
        }

        public override void AI() {
            Projectile.rotation = (float)(Math.Atan2(Projectile.velocity.Y, Projectile.velocity.X)) + MathHelper.ToRadians(90);
        }
    }

    public class StickM2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Greedy Stick");
        }

        public override void AutoStaticDefaults() {
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/GreedyStick");
        }

        public override void SetDefaults() {
            Projectile.width = 20;
            Projectile.height = 4;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 5;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool cri) {
            int value = Main.rand.Next(200, 2000);
            
            if (target.type != NPCID.TargetDummy) {
                if (value >= 100) {
                    double partialValue = (double)value/(double)100;
                    int roundedValue = (int)Math.Floor(partialValue);
                    Item.NewItem(null, target.getRect(), ItemID.SilverCoin, roundedValue);
                    Item.NewItem(null, target.getRect(), ItemID.CopperCoin, (int)(partialValue-roundedValue));
                } else {
                    Item.NewItem(null, target.getRect(), ItemID.CopperCoin, value);
                }
            }
        }
    }

    public class StickK2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Spooky Stick");
        }

        public override void AutoStaticDefaults() {
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/SpookyStick");
        }

        public override void SetDefaults() {
            Projectile.width = 20;
            Projectile.height = 4;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 1;
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
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/StickofTears");
        }

        public override void SetDefaults() {
            Projectile.width = 20;
            Projectile.height = 4;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 999;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool cri) {
            target.AddBuff(Mod.Find<ModBuff>("Mourning").Type, 10 * 60);
        }

        public override void OnHitPvp(Player target, int damage, bool cri) {
            target.AddBuff(Mod.Find<ModBuff>("Mourning").Type, 10 * 60);
        }

        public override void Kill(int timeLeft) {
            for (int i = 0; i <= 2; i++) {
                Dust.NewDust(Projectile.position, 0, 0, 253, 0f, 0f, 0, new Color(78,94,176), 0.55f);
            }
        }
    }

    public class StickMoon2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Lunar Stick");
        }

        public override void AutoStaticDefaults() {
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/LunarStick");
        }

        public override void SetDefaults() {
            Projectile.width = 20;
            Projectile.height = 4;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            Projectile.DamageType = DamageClass.Ranged;
        }

        public override void Kill(int timeLeft) {
            for (int i = 0; i <= 2; i++) {
                Dust.NewDust(Projectile.position, 0, 0, 1, 0f, 0f, 0, new Color(155, 155, 155), 0.75f);
            }
        }
    }

    public class StickCosmilite2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Cosmilite Stick");
        }

        public override void AutoStaticDefaults() {
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/CosmiliteStick");
        }

        public override void SetDefaults() {
            Projectile.width = 20;
            Projectile.height = 4;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 1;
        }
    }

    public class AetherStick : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Ether Stick");
        }

        public override void AutoStaticDefaults() {
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/EtherStick_Projectile");
        }

        public override void SetDefaults() {
            Projectile.width = 4;
            Projectile.height = 20;
            Projectile.aiStyle = -1;
            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 1;
            Projectile.extraUpdates = 1;
        }

        public override void AI() {
            Projectile.rotation = (float)(Math.Atan2(Projectile.velocity.Y, Projectile.velocity.X));
            Projectile.damage += 2;
        }
    }

    public class StickItem : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Stick");
        }

        public override string Texture { get { return "ABigStick/Items/Stick"; } }

        public override void SetDefaults() {
            Item.damage = 3;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 4;
            Item.height = 20;
            Item.consumable = true;
            Item.knockBack = 1f;
            Item.value = 2;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.ammo = Item.type;
            Item.maxStack = 999;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe(30);
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.Register();
            Recipe recipe3 = CreateRecipe(30);
            recipe3.AddIngredient(ItemID.PalmWood, 1);
            recipe3.Register();
            Recipe recipe4 = CreateRecipe(30);
            recipe4.AddIngredient(ItemID.RichMahogany, 1);
            recipe4.Register();
        }
    }

    public class HighVelocityStickItem : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("High Velocity Stick");
        }

        public override string Texture { get { return "ABigStick/Items/HighVelocityStick"; } }

        public override void SetDefaults() {
            Item.damage = 7;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 4;
            Item.height = 20;
            Item.consumable = true;
            Item.knockBack = 1f;
            Item.value = 7;
            Item.rare = 3;
            Item.shoot = Mod.Find<ModProjectile>("HighVelocityStick").Type;
            Item.ammo = Mod.Find<ModItem>("StickItem").Type;
            Item.maxStack = 999;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe(100);
            recipe.AddRecipeGroup("ABigStick:Sticks", 100);
            recipe.AddIngredient(ItemID.Cog, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }

    public class PenetratingStickItem : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Meteorite Stick");
        }

        public override string Texture { get { return "ABigStick/Items/MeteoriteStick"; } }

        public override void SetDefaults() {
            Item.damage = 5;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 4;
            Item.height = 20;
            Item.consumable = true;
            Item.knockBack = 1f;
            Item.value = 6;
            Item.rare = 1;
            Item.shoot = Mod.Find<ModProjectile>("PenetratingStick").Type;
            Item.ammo = Mod.Find<ModItem>("StickItem").Type;
            Item.maxStack = 999;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe(150);
            recipe.AddIngredient(ItemID.MeteoriteBar, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }

    public class StickH : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Pearlstick");
            Tooltip.SetDefault("Inflicts Slow");
        }

        public override string Texture { get { return "ABigStick/Items/HallowedStick"; } }

        public override void SetDefaults() {
            Item.damage = 5;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 4;
            Item.height = 20;
            Item.consumable = true;
            Item.knockBack = 1f;
            Item.value = 10;
            Item.shoot = Mod.Find<ModProjectile>("StickH2").Type;
            Item.ammo = Mod.Find<ModItem>("StickItem").Type;
            Item.maxStack = 999;
            Item.rare = 4;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe(30);
            recipe.AddIngredient(ItemID.Pearlwood, 1);
            recipe.Register();
        }
    }

    public class StickCo : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Ebonstick");
            Tooltip.SetDefault("Inflicts Cursed Inferno");
        }

        public override string Texture { get { return "ABigStick/Items/CorruptionStick"; } }

        public override void SetDefaults() {
            Item.damage = 5;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 4;
            Item.height = 20;
            Item.consumable = true;
            Item.knockBack = 1f;
            Item.value = 100;
            Item.shoot = Mod.Find<ModProjectile>("StickCo2").Type;
            Item.ammo = Mod.Find<ModItem>("StickItem").Type;
            Item.maxStack = 999;
            Item.rare = 2;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe(30);
            recipe.AddIngredient(ItemID.Ebonwood, 1);
            recipe.Register();
        }
    }

    public class StickCr : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Shadestick");
            Tooltip.SetDefault("Inflicts Ichor");
        }

        public override string Texture { get { return "ABigStick/Items/CrimsonStick"; } }

        public override void SetDefaults() {
            Item.damage = 7;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 4;
            Item.height = 20;
            Item.consumable = true;
            Item.knockBack = 1f;
            Item.value = 100;
            Item.shoot = Mod.Find<ModProjectile>("StickCr2").Type;
            Item.ammo = Mod.Find<ModItem>("StickItem").Type;
            Item.maxStack = 999;
            Item.rare = 2;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe(30);
            recipe.AddIngredient(ItemID.Shadewood, 1);
            recipe.Register();
        }
    }

    public class StickBo : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Boreal Stick");
            Tooltip.SetDefault("Inflicts Chilled");
        }

        public override string Texture { get { return "ABigStick/Items/BorealStick"; } }

        public override void SetDefaults() {
            Item.damage = 3;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 4;
            Item.height = 20;
            Item.consumable = true;
            Item.knockBack = 1f;
            Item.value = 100;
            Item.shoot = Mod.Find<ModProjectile>("StickBo2").Type;
            Item.ammo = Mod.Find<ModItem>("StickItem").Type;
            Item.maxStack = 999;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe(30);
            recipe.AddIngredient(ItemID.BorealWood, 1);
            recipe.Register();
        }
    }

    public class StickL : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Luminite Stick");
            Tooltip.SetDefault("Increases in damage the more targets it pierces through\n'This is irrational.'");
        }

        public override string Texture { get { return "ABigStick/Items/LuminiteStick"; } }

        public override void SetDefaults() {
            Item.damage = 15;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 4;
            Item.height = 20;
            Item.consumable = true;
            Item.knockBack = 4f;
            Item.value = 0;
            Item.rare = 9;
            Item.shoot = Mod.Find<ModProjectile>("StickL2").Type;
            Item.ammo = Mod.Find<ModItem>("StickItem").Type;
            Item.crit = 30;            
            Item.maxStack = 999;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe(333);
            recipe.AddIngredient(ItemID.LunarBar, 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
    

    public class StickD : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Rainbow Stick");
            Tooltip.SetDefault("'Physics? What's that?'");
            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 7));
        }

        public override string Texture { get { return "ABigStick/Items/RainbowStickItem"; } }

        public override void SetDefaults() {
            Item.damage = 9999;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 4;
            Item.height = 20;
            Item.consumable = true;
            Item.knockBack = 4f;
            Item.value = 9999999;
            Item.rare = 11;
            Item.expert = true;
            Item.shoot = Mod.Find<ModProjectile>("StickD2").Type;
            Item.ammo = Mod.Find<ModItem>("StickItem").Type;
            Item.crit = 30;
            Item.maxStack = 999;
        }
    }

    public class StickM : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Greedy Stick");
            Tooltip.SetDefault("Steals money on impact");
        }

        public override string Texture { get { return "ABigStick/Items/GreedyStick"; } }

        public override void SetDefaults() {
            Item.damage = 7;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 4;
            Item.height = 20;
            Item.consumable = true;
            Item.knockBack = 0f;
            Item.value = 200;
            Item.shoot = Mod.Find<ModProjectile>("StickM2").Type;
            Item.ammo = Mod.Find<ModItem>("StickItem").Type;
            Item.crit = 20;
            Item.rare = 4;
            Item.maxStack = 999;
        }
    }

    public class StickK : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Spooky Stick");
            Tooltip.SetDefault("33% chance to inflict Confused");
        }

        public override string Texture { get { return "ABigStick/Items/SpookyStick"; } }

        public override void SetDefaults() {
            Item.damage = 4;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 4;
            Item.height = 20;
            Item.consumable = true;
            Item.knockBack = 0f;
            Item.value = 200;
            Item.shoot = Mod.Find<ModProjectile>("StickK2").Type;
            Item.ammo = Mod.Find<ModItem>("StickItem").Type;
            Item.maxStack = 999;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe(30);
            recipe.AddIngredient(ItemID.SpookyWood, 1);
            recipe.Register();
        }
    }

    public class StickAten : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Stick of Tears");
            Tooltip.SetDefault("'Forged from their final tears'");
        }

        public override string Texture { get { return "ABigStick/Items/StickofTears"; } }

        public override void SetDefaults() {
            Item.damage = 12;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 4;
            Item.height = 20;
            Item.consumable = true;
            Item.knockBack = 2f;
            Item.value = 10;
            Item.shoot = Mod.Find<ModProjectile>("StickAten2").Type;
            Item.ammo = Mod.Find<ModItem>("StickItem").Type;
            Item.maxStack = 999;
            Item.rare = 3;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe(500);
            recipe.AddIngredient(Mod.Find<ModItem>("LastTears").Type, 25);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }

    public class StickMoon : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Lunar Stick");
            Tooltip.SetDefault("'Raw power resonates throughout the stick'");
        }

        public override string Texture { get { return "ABigStick/Items/LunarStick"; } }

        public override void SetDefaults() {
            Item.damage = 35;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 4;
            Item.height = 20;
            Item.consumable = true;
            Item.knockBack = 2f;
            Item.value = 12500;
            Item.shoot = Mod.Find<ModProjectile>("StickMoon2").Type;
            Item.ammo = Mod.Find<ModItem>("StickItem").Type;
            Item.maxStack = 999;
            Item.rare = 11;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe(200);
            recipe.AddIngredient(Mod.Find<ModItem>("MoonTears").Type, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }

    public class AetherStickItem : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Ether Stick");
            Tooltip.SetDefault("Takes time to build up strength");
        }

        public override string Texture { get { return "ABigStick/Items/EtherStick"; } }

        public override void SetDefaults() {
            Item.damage = 10;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 4;
            Item.height = 12;
            Item.consumable = true;
            Item.knockBack = 2f;
            Item.value = 20;
            Item.shoot = Mod.Find<ModProjectile>("AetherStick").Type;
            Item.ammo = Mod.Find<ModItem>("StickItem").Type;
            Item.maxStack = 999;
            Item.rare = 10;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe(333);
            recipe.AddIngredient(ItemID.FragmentVortex, 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();

            Recipe recipe2 = CreateRecipe(333);
            recipe2.AddIngredient(ItemID.FragmentNebula, 1);
            recipe2.AddTile(TileID.LunarCraftingStation);
            recipe2.Register();

            Recipe recipe3 = CreateRecipe(333);
            recipe3.AddIngredient(ItemID.FragmentSolar, 1);
            recipe3.AddTile(TileID.LunarCraftingStation);
            recipe3.Register();

            Recipe recipe4 = CreateRecipe(333);
            recipe4.AddIngredient(ItemID.FragmentStardust, 1);
            recipe4.AddTile(TileID.LunarCraftingStation);
            recipe4.Register();
        }
    }

    public class StickCosmilite : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Cosmilite Stick");
            Tooltip.SetDefault("'Not a fan of game mechanics'");
        }

        public override string Texture { get { return "ABigStick/Items/CosmiliteStick"; } }

        public override void SetDefaults() {
            Item.damage = 85;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 4;
            Item.height = 20;
            Item.consumable = true;
            Item.knockBack = 2f;
            Item.value = 12500;
            Item.shoot = Mod.Find<ModProjectile>("StickCosmilite2").Type;
            Item.ammo = Mod.Find<ModItem>("StickItem").Type;
            Item.maxStack = 999;
            Item.rare = 11;
        }

        public override void AddRecipes() {
            ModLoader.TryGetMod("CalamityMod", out Mod calamityMod);
            if (calamityMod != null) {
                Recipe recipe = CreateRecipe(200);
                recipe.AddIngredient(calamityMod.Find<ModItem>("CosmiliteBar").Type, 5);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.Register();
            }
        }
    }

    public class Drops : GlobalNPC {
        public override void OnKill(NPC npc) {
            int count = Main.rand.Next(5, 10);
            if (Main.rand.NextBool(Main.expertMode ? 2 : 1, 5)) {
                count = count * 2;
            }
            if (((npc.type >= 212 && npc.type <= 216) || npc.type == 229 || npc.type == 252)) { // all pirates and parrots
                if (Main.rand.NextFloat() >= .75f) {
                    Item.NewItem(null, npc.getRect(), Mod.Find<ModItem>("StickM").Type, count);
                }
            } else if (npc.type == 491) { // pirate ship
                Item.NewItem(null, npc.getRect(), Mod.Find<ModItem>("StickM").Type, count*20);
            }

            if (npc.type == 398) { // moon lord's core
                Item.NewItem(null, npc.getRect(), Mod.Find<ModItem>("MoonTears").Type, Main.rand.Next(5, 8));
            } else if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].GetModPlayer<ABigPlayer>().hasTearNet) {
                if (Main.rand.NextFloat() <= .75f && npc.type != 401 && npc.lifeMax > 5) { // moon lord's leech can't drop tears, and neither can critters
                    Item.NewItem(null, npc.getRect(), Mod.Find<ModItem>("LastTears").Type, Main.rand.Next(1, 3));
                }
            }
        }
    }
}