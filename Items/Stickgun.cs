using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace ABigStick.Items {
    // Backwards compatibility stickgun
    public class Stickgun : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("IOU a Clockwork Stickgun");
            Tooltip.SetDefault("<right> to obtain a Clockwork Stickgun");
        }

        public override string Texture { get { return "ABigStick/Items/1/Crit"; } }

        public override void SetDefaults() {
            Item.value = 0;
            Item.rare = 10;
            Item.maxStack = 1;
        }

        public override bool CanRightClick() {
            return true;
        }

        public override void RightClick(Player player) {
            player.QuickSpawnItem(null, Mod.Find<ModItem>("EmotionalStickgun").Type);
        }
    }

    // Level -1 Stickgun (DPS-based)
    public class WoodenStickgun : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Wooden Stickgun");
            Tooltip.SetDefault("Uses sticks as ammo");
        }

        public override string Texture { get { return "ABigStick/Items/-1/DPS"; } }

        public override void SetDefaults() {
            Item.damage = 9;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 25;
            Item.height = 13;
            Item.maxStack = 1;
            Item.useTime = 23;
            Item.useAnimation = 23;
            Item.useStyle = 5;
            Item.knockBack = 2;
            Item.value = 100;
            Item.rare = 0;
            Item.crit = 5;
            Item.UseSound = SoundID.Item40;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }

    // Level -1 Stickgun (Crit-based)
    public class WoodenStickSniper : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Wooden Stickrifle");
            Tooltip.SetDefault("Uses sticks as ammo");
        }

        public override string Texture { get { return "ABigStick/Items/-1/Crit"; } }

        public override void SetDefaults() {
            Item.damage = 13;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 35;
            Item.height = 8;
            Item.maxStack = 1;
            Item.useTime = 41;
            Item.useAnimation = 41;
            Item.useStyle = 5;
            Item.knockBack = 2;
            Item.value = 100;
            Item.rare = 0;
            Item.crit = 30;
            Item.UseSound = SoundID.Item36;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }

    // Level 0 Stickgun (DPS-based)
    public class Lvl0Stickgun : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Demonite Stickgun");
            Tooltip.SetDefault("Uses sticks as ammo");
        }

        public override string Texture { get { return "ABigStick/Items/0/DPS"; } }

        public override void SetDefaults() {
            Item.damage = 25;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 26;
            Item.height = 13;
            Item.maxStack = 1;
            Item.useTime = 18;
            Item.useAnimation = 18;
            Item.useStyle = 5;
            Item.knockBack = 2;
            Item.value = 100;
            Item.rare = 1;
            Item.crit = 5;
            Item.UseSound = SoundID.Item40;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DemoniteBar, 15);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();

            // Upgrading from previous tier
            Recipe upgrade = CreateRecipe();
            upgrade.AddIngredient(Mod.Find<ModItem>("WoodenStickgun").Type);
            upgrade.AddIngredient(ItemID.DemoniteBar, 14);
            upgrade.AddTile(TileID.Anvils);
            upgrade.Register();
        }
    }

    // Level 0 Stickgun (Crit-based)
    public class Lvl0StickSniper : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Demonite Stickrifle");
            Tooltip.SetDefault("Uses sticks as ammo");
        }

        public override string Texture { get { return "ABigStick/Items/0/Crit"; } }

        public override void SetDefaults() {
            Item.damage = 47;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 35;
            Item.height = 8;
            Item.maxStack = 1;
            Item.useTime = 39;
            Item.useAnimation = 39;
            Item.useStyle = 5;
            Item.knockBack = 3;
            Item.value = 100;
            Item.rare = 1;
            Item.crit = 35;
            Item.UseSound = SoundID.Item36;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DemoniteBar, 15);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();

            // Upgrading from previous tier
            Recipe upgrade = CreateRecipe();
            upgrade.AddIngredient(Mod.Find<ModItem>("WoodenStickSniper").Type);
            upgrade.AddIngredient(ItemID.DemoniteBar, 14);
            upgrade.AddTile(TileID.Anvils);
            upgrade.Register();
        }
    }

    // Level 0 Stickgun (DPS-based)
    public class Lvl0StickgunC : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Crimtane Stickgun");
            Tooltip.SetDefault("Uses sticks as ammo");
        }

        public override string Texture { get { return "ABigStick/Items/0/DPS_C"; } }

        public override void SetDefaults() {
            Item.damage = 27;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 26;
            Item.height = 13;
            Item.maxStack = 1;
            Item.useTime = 18;
            Item.useAnimation = 18;
            Item.useStyle = 5;
            Item.knockBack = 2;
            Item.value = 100;
            Item.rare = 1;
            Item.crit = 5;
            Item.UseSound = SoundID.Item40;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.CrimtaneBar, 15);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();

            // Upgrading from previous tier
            Recipe upgrade = CreateRecipe();
            upgrade.AddIngredient(Mod.Find<ModItem>("WoodenStickgun").Type);
            upgrade.AddIngredient(ItemID.CrimtaneBar, 14);
            upgrade.AddTile(TileID.Anvils);
            upgrade.Register();
        }
    }

    // Level 0 Stickgun (Crit-based)
    public class Lvl0StickSniperC : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Crimtane Stickrifle");
            Tooltip.SetDefault("Uses sticks as ammo");
        }

        public override string Texture { get { return "ABigStick/Items/0/Crit_C"; } }

        public override void SetDefaults() {
            Item.damage = 47;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 35;
            Item.height = 8;
            Item.maxStack = 1;
            Item.useTime = 39;
            Item.useAnimation = 39;
            Item.useStyle = 5;
            Item.knockBack = 3;
            Item.value = 100;
            Item.rare = 1;
            Item.crit = 35;
            Item.UseSound = SoundID.Item36;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.CrimtaneBar, 15);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();

            // Upgrading from previous tier
            Recipe upgrade = CreateRecipe();
            upgrade.AddIngredient(Mod.Find<ModItem>("WoodenStickSniper").Type);
            upgrade.AddIngredient(ItemID.CrimtaneBar, 14);
            upgrade.AddTile(TileID.Anvils);
            upgrade.Register();
        }
    }
    
    // Level 1 Stickgun (DPS-based)
    public class Lvl1Stickgun : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Hellstone Stickgun");
            Tooltip.SetDefault("Uses sticks as ammo");
        }

        public override string Texture { get { return "ABigStick/Items/1/DPS"; } }

        public override void SetDefaults() {
            Item.damage = 32;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 26;
            Item.height = 13;
            Item.maxStack = 1;
            Item.useTime = 16;
            Item.useAnimation = 16;
            Item.useStyle = 5;
            Item.knockBack = 2;
            Item.value = 3000;
            Item.rare = 3;
            Item.crit = 5;
            Item.UseSound = SoundID.Item40;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();

            // Upgrading from previous tier
            Recipe upgrade = CreateRecipe();
            upgrade.AddIngredient(Mod.Find<ModItem>("Lvl0Stickgun").Type);
            upgrade.AddIngredient(ItemID.HellstoneBar, 14);
            upgrade.AddTile(TileID.Anvils);
            upgrade.Register();

            // Upgrading from previous tier
            Recipe upgrade2 = CreateRecipe();
            upgrade2.AddIngredient(Mod.Find<ModItem>("Lvl0StickgunC").Type);
            upgrade2.AddIngredient(ItemID.HellstoneBar, 14);
            upgrade2.AddTile(TileID.Anvils);
            upgrade2.Register();
        }
    }

    // Level 1 Stickgun (Crit-based)
    public class StickSniper : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Hellstone Stickrifle");
            Tooltip.SetDefault("Uses sticks as ammo");
        }

        public override string Texture { get { return "ABigStick/Items/1/Crit"; } }

        public override void SetDefaults() {
            Item.damage = 55;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 35;
            Item.height = 8;
            Item.maxStack = 1;
            Item.useTime = 36;
            Item.useAnimation = 36;
            Item.useStyle = 5;
            Item.knockBack = 4;
            Item.value = 3000;
            Item.rare = 3;
            Item.crit = 30;
            Item.UseSound = SoundID.Item36;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            // Making a brand new stickgun
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();

            // Upgrading from previous tier
            Recipe upgrade = CreateRecipe();
            upgrade.AddIngredient(Mod.Find<ModItem>("Lvl0StickSniper").Type);
            upgrade.AddIngredient(ItemID.HellstoneBar, 14);
            upgrade.AddTile(TileID.Anvils);
            upgrade.Register();

            // Upgrading from previous tier
            Recipe upgrade2 = CreateRecipe();
            upgrade2.AddIngredient(Mod.Find<ModItem>("Lvl0StickSniperC").Type);
            upgrade2.AddIngredient(ItemID.HellstoneBar, 14);
            upgrade2.AddTile(TileID.Anvils);
            upgrade2.Register();
        }
    }

    // Level 2 Stickgun (Adamantite, DPS-based)
    public class Lvl2StickgunA : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Adamantite Stickgun");
            Tooltip.SetDefault("Uses sticks as ammo\n25% chance to not consume ammo");
        }

        public override string Texture { get { return "ABigStick/Items/2/DPS_A"; } }

        public override void SetDefaults() {
            Item.damage = 45;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 30;
            Item.height = 15;
            Item.maxStack = 1;
            Item.useTime = 14;
            Item.useAnimation = 14;
            Item.useStyle = 5;
            Item.knockBack = 2;
            Item.value = 7000;
            Item.rare = 4;
            Item.crit = 5;
            Item.UseSound = SoundID.Item40;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            // Making a brand new stickgun
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.AdamantiteBar, 12);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();

            // Upgrading from previous tier
            Recipe upgrade = CreateRecipe();
            upgrade.AddIngredient(Mod.Find<ModItem>("Lvl1Stickgun").Type);
            upgrade.AddIngredient(ItemID.AdamantiteBar, 11);
            upgrade.AddTile(TileID.MythrilAnvil);
            upgrade.Register();
        }

        public override bool CanConsumeAmmo(Item ammo, Player player) {
            return Main.rand.NextFloat() >= .25f;
        }
    }

    // Level 2 Stickgun (Titanium, DPS-based)
    public class Lvl2StickgunT : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Titanium Stickgun");
            Tooltip.SetDefault("Uses sticks as ammo\n25% chance to not consume ammo");
        }

        public override string Texture { get { return "ABigStick/Items/2/DPS_T"; } }

        public override void SetDefaults() {
            Item.damage = 47;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 30;
            Item.height = 15;
            Item.maxStack = 1;
            Item.useTime = 14;
            Item.useAnimation = 14;
            Item.useStyle = 5;
            Item.knockBack = 2;
            Item.value = 7000;
            Item.rare = 4;
            Item.crit = 5;
            Item.UseSound = SoundID.Item40;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            // Making a brand new stickgun
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.TitaniumBar, 12);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();

            // Upgrading from previous tier
            Recipe upgrade = CreateRecipe();
            upgrade.AddIngredient(Mod.Find<ModItem>("Lvl1Stickgun").Type);
            upgrade.AddIngredient(ItemID.TitaniumBar, 11);
            upgrade.AddTile(TileID.MythrilAnvil);
            upgrade.Register();
        }

        public override bool CanConsumeAmmo(Item ammo, Player player) {
            return Main.rand.NextFloat() >= .25f;
        }
    }

    // Level 2 Stickgun (Adamantite, crit-based)
    public class Lvl2StickSniperA : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Adamantite Stickrifle");
            Tooltip.SetDefault("Uses sticks as ammo");
        }

        public override string Texture { get { return "ABigStick/Items/2/Crit_A"; } }

        public override void SetDefaults() {
            Item.damage = 72;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 39;
            Item.height = 8;
            Item.maxStack = 1;
            Item.useTime = 34;
            Item.useAnimation = 34;
            Item.useStyle = 5;
            Item.knockBack = 5;
            Item.value = 7000;
            Item.rare = 3;
            Item.crit = 35;
            Item.UseSound = SoundID.Item36;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            // Making a brand new stickgun
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.AdamantiteBar, 12);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();

            // Upgrading from previous tier
            Recipe upgrade = CreateRecipe();
            upgrade.AddIngredient(Mod.Find<ModItem>("StickSniper").Type);
            upgrade.AddIngredient(ItemID.AdamantiteBar, 11);
            upgrade.AddTile(TileID.MythrilAnvil);
            upgrade.Register();
        }
    }

    // Level 2 Stickgun (Titanium, crit-based)
    public class Lvl2StickSniperT : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Titanium Stickrifle");
            Tooltip.SetDefault("Uses sticks as ammo");
        }

        public override string Texture { get { return "ABigStick/Items/2/Crit_T"; } }

        public override void SetDefaults() {
            Item.damage = 75;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 39;
            Item.height = 8;
            Item.maxStack = 1;
            Item.useTime = 34;
            Item.useAnimation = 34;
            Item.useStyle = 5;
            Item.knockBack = 5;
            Item.value = 7000;
            Item.rare = 3;
            Item.crit = 35;
            Item.UseSound = SoundID.Item36;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            // Making a brand new stickgun
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.TitaniumBar, 12);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();

            // Upgrading from previous tier
            Recipe upgrade = CreateRecipe();
            upgrade.AddIngredient(Mod.Find<ModItem>("StickSniper").Type);
            upgrade.AddIngredient(ItemID.TitaniumBar, 11);
            upgrade.AddTile(TileID.MythrilAnvil);
            upgrade.Register();
        }
    }

    // Level 3 Stickgun (DPS-based)
    public class Lvl3Stickgun : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Autotrophic Stickgun");
            Tooltip.SetDefault("Uses sticks as ammo\n35% chance to not consume ammo");
        }

        public override string Texture { get { return "ABigStick/Items/3/DPS"; } }

        public override void SetDefaults() {
            Item.damage = 55;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 33;
            Item.height = 15;
            Item.maxStack = 1;
            Item.useTime = 13;
            Item.useAnimation = 13;
            Item.useStyle = 5;
            Item.knockBack = 2;
            Item.value = 13000;
            Item.rare = 7;
            Item.crit = 5;
            Item.UseSound = SoundID.Item40;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            // Making a brand new stickgun
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.ChlorophyteBar, 12);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();

            // Upgrading from previous tier
            Recipe upgradeA = CreateRecipe();
            upgradeA.AddIngredient(Mod.Find<ModItem>("Lvl2StickgunA").Type);
            upgradeA.AddIngredient(ItemID.ChlorophyteBar, 11);
            upgradeA.AddTile(TileID.MythrilAnvil);
            upgradeA.Register();

            Recipe upgradeT = CreateRecipe();
            upgradeT.AddIngredient(Mod.Find<ModItem>("Lvl2StickgunT").Type);
            upgradeT.AddIngredient(ItemID.ChlorophyteBar, 11);
            upgradeT.AddTile(TileID.MythrilAnvil);
            upgradeT.Register();
        }

        public override bool CanConsumeAmmo(Item ammo, Player player) {
            return Main.rand.NextFloat() >= .35f;
        }
    }

    // Level 3 Stickgun (Crit-based)
    public class Lvl3StickSniper : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Autotrophic Stickrifle");
            Tooltip.SetDefault("Uses sticks as ammo");
        }

        public override string Texture { get { return "ABigStick/Items/3/Crit"; } }

        public override void SetDefaults() {
            Item.damage = 95;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 42;
            Item.height = 9;
            Item.maxStack = 1;
            Item.useTime = 31;
            Item.useAnimation = 31;
            Item.useStyle = 5;
            Item.knockBack = 6;
            Item.value = 13000;
            Item.rare = 7;
            Item.crit = 50;
            Item.UseSound = SoundID.Item36;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            // Making a brand new stickgun
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.ChlorophyteBar, 12);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();

            // Upgrading from previous tier
            Recipe upgradeA = CreateRecipe();
            upgradeA.AddIngredient(Mod.Find<ModItem>("Lvl2StickSniperA").Type);
            upgradeA.AddIngredient(ItemID.ChlorophyteBar, 11);
            upgradeA.AddTile(TileID.MythrilAnvil);
            upgradeA.Register();

            Recipe upgradeT = CreateRecipe();
            upgradeT.AddIngredient(Mod.Find<ModItem>("Lvl2StickSniperT").Type);
            upgradeT.AddIngredient(ItemID.ChlorophyteBar, 11);
            upgradeT.AddTile(TileID.MythrilAnvil);
            upgradeT.Register();
        }
    }

    // Level 4 Stickgun (DPS-based)
    public class Lvl4Stickgun : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Spectre Stickgun");
            Tooltip.SetDefault("Uses sticks as ammo\n45% chance to not consume ammo");
        }

        public override string Texture { get { return "ABigStick/Items/4/DPS"; } }

        public override void SetDefaults() {
            Item.damage = 70;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 20;
            Item.maxStack = 1;
            Item.useTime = 9;
            Item.useAnimation = 9;
            Item.useStyle = 5;
            Item.knockBack = 2;
            Item.value = 17000;
            Item.rare = 8;
            Item.crit = 5;
            Item.UseSound = SoundID.Item40;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            // Making a brand new stickgun
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SpectreBar, 12);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();

            // Upgrading from previous tier
            Recipe upgrade = CreateRecipe();
            upgrade.AddIngredient(Mod.Find<ModItem>("Lvl3Stickgun").Type);
            upgrade.AddIngredient(ItemID.SpectreBar, 11);
            upgrade.AddTile(TileID.MythrilAnvil);
            upgrade.Register();
        }

        public override bool CanConsumeAmmo(Item ammo, Player player) {
            return Main.rand.NextFloat() >= .45f;
        }
    }

    // Level 4 Stickgun (Crit-based)
    public class Lvl4StickSniper : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Spectre Stickrifle");
            Tooltip.SetDefault("Uses sticks as ammo");
        }

        public override string Texture { get { return "ABigStick/Items/4/Crit"; } }

        public override void SetDefaults() {
            Item.damage = 135;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 48;
            Item.height = 12;
            Item.maxStack = 1;
            Item.useTime = 28;
            Item.useAnimation = 28;
            Item.useStyle = 5;
            Item.knockBack = 7;
            Item.value = 17000;
            Item.rare = 8;
            Item.crit = 50;
            Item.UseSound = SoundID.Item36;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            // Making a brand new stickgun
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SpectreBar, 12);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();

            // Upgrading from previous tier
            Recipe upgrade = CreateRecipe();
            upgrade.AddIngredient(Mod.Find<ModItem>("Lvl3StickSniper").Type);
            upgrade.AddIngredient(ItemID.SpectreBar, 11);
            upgrade.AddTile(TileID.MythrilAnvil);
            upgrade.Register();
        }
    }

    // Level 5 Stickgun (DPS-based)
    public class Lvl5Stickgun : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Lunar Stickgun");
            Tooltip.SetDefault("Uses sticks as ammo\n55% chance to not consume ammo");
        }

        public override string Texture { get { return "ABigStick/Items/5/DPS"; } }

        public override void SetDefaults() {
            Item.damage = 75;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 47;
            Item.height = 21;
            Item.maxStack = 1;
            Item.useTime = 6;
            Item.useAnimation = 6;
            Item.useStyle = 5;
            Item.knockBack = 2;
            Item.value = 2500;
            Item.rare = 10;
            Item.crit = 5;
            Item.UseSound = SoundID.Item40;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            // Making a brand new stickgun
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.FragmentVortex, 28);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();

            // Upgrading from previous tier
            Recipe upgrade = CreateRecipe();
            upgrade.AddIngredient(Mod.Find<ModItem>("Lvl4Stickgun").Type);
            upgrade.AddIngredient(ItemID.FragmentVortex, 27);
            upgrade.AddTile(TileID.LunarCraftingStation);
            upgrade.Register();
        }

        public override bool CanConsumeAmmo(Item ammo, Player player) {
            return Main.rand.NextFloat() >= .55f;
        }
    }

    // Level 5 Stickgun (Crit-based)
    public class Lvl5StickSniper : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Lunar Stickrifle");
            Tooltip.SetDefault("Uses sticks as ammo");
        }

        public override string Texture { get { return "ABigStick/Items/5/Crit"; } }

        public override void SetDefaults() {
            Item.damage = 185;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 48;
            Item.height = 13;
            Item.maxStack = 1;
            Item.useTime = 23;
            Item.useAnimation = 23;
            Item.useStyle = 5;
            Item.knockBack = 8;
            Item.value = 17000;
            Item.rare = 10;
            Item.crit = 50;
            Item.UseSound = SoundID.Item36;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 20f;
            Item.autoReuse = true;
        }

        public override void AddRecipes() {
            // Making a brand new stickgun
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.FragmentVortex, 28);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();

            // Upgrading from previous tier
            Recipe upgrade = CreateRecipe();
            upgrade.AddIngredient(Mod.Find<ModItem>("Lvl4StickSniper").Type);
            upgrade.AddIngredient(ItemID.FragmentVortex, 27);
            upgrade.AddTile(TileID.LunarCraftingStation);
            upgrade.Register();
        }
    }

    // Level 6 Stickgun (DPS-based)
    public class EmotionalStickgun : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Clockwork Stickgun");
            Tooltip.SetDefault("Uses sticks as ammo\n70% chance to not consume ammo");
        }

        public override string Texture { get { return "ABigStick/Items/6/DPS"; } }

        public override void SetDefaults() {
            Item.damage = 95;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 53;
            Item.height = 22;
            Item.maxStack = 1;
            Item.useTime = 5;
            Item.useAnimation = 5;
            Item.useStyle = 5;
            Item.knockBack = 4;
            Item.value = 500000;
            Item.rare = 11;
            Item.crit = 15;
            Item.UseSound = SoundID.Item40;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 40f;
            Item.autoReuse = true;
        }

        public override bool CanConsumeAmmo(Item ammo, Player player) {
            return Main.rand.NextFloat() >= .70f;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Phantasm, 1);
            recipe.AddIngredient(ItemID.LunarBar, 5);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
            Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(ItemID.VortexBeater, 1);
            recipe2.AddIngredient(ItemID.LunarBar, 5);
            recipe2.AddIngredient(ItemID.Wood, 50);
            recipe2.AddTile(TileID.LunarCraftingStation);
            recipe2.Register();

            Recipe upgrade = CreateRecipe();
            upgrade.AddIngredient(Mod.Find<ModItem>("Lvl5Stickgun").Type);
            upgrade.AddIngredient(ItemID.LunarBar, 5);
            upgrade.AddTile(TileID.LunarCraftingStation);
            upgrade.Register();
        }
    }

    // Level 6 Stickgun (Crit-based)
    public class EmotionalStickRifle : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Clockwork Stickrifle");
            Tooltip.SetDefault("Uses sticks as ammo");
        }

        public override string Texture { get { return "ABigStick/Items/6/Crit"; } }

        public override void SetDefaults() {
            Item.damage = 255;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 52;
            Item.height = 15;
            Item.maxStack = 1;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = 5;
            Item.knockBack = 9;
            Item.value = 500000;
            Item.rare = 11;
            Item.crit = 50;
            Item.UseSound = SoundID.Item36;
            Item.noMelee = true;
            Item.shoot = Mod.Find<ModProjectile>("Stick").Type;
            Item.useAmmo = Mod.Find<ModItem>("StickItem").Type;
            Item.shootSpeed = 40f;
            Item.autoReuse = true;
        }
        
        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Phantasm, 1);
            recipe.AddIngredient(ItemID.LunarBar, 5);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
            Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(ItemID.VortexBeater, 1);
            recipe2.AddIngredient(ItemID.LunarBar, 5);
            recipe2.AddIngredient(ItemID.Wood, 50);
            recipe2.AddTile(TileID.LunarCraftingStation);
            recipe2.Register();

            Recipe upgrade = CreateRecipe();
            upgrade.AddIngredient(Mod.Find<ModItem>("Lvl5StickSniper").Type);
            upgrade.AddIngredient(ItemID.LunarBar, 5);
            upgrade.AddTile(TileID.LunarCraftingStation);
            upgrade.Register();
        }
    }

    public class StickgunBossSpawner : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Twitching Stickgun");
            Tooltip.SetDefault("'Imbued with the spark of life'");
        }

        public override string Texture { get { return "ABigStick/Items/6/Crit"; } }

        public override void SetDefaults() {
            Item.width = 80;
            Item.height = 14;
            Item.maxStack = 1;
            Item.useAnimation = 45;
            Item.useTime = 45;
            Item.useStyle = 4;
            Item.consumable = true;
            Item.rare = 11;
        }

        public override bool CanUseItem(Player player) {
            return !NPC.AnyNPCs(Mod.Find<ModNPC>("SentientStickgun").Type);
        }

        public override bool? UseItem(Player player)/* tModPorter Suggestion: Return null instead of false */ {
            NPC.SpawnOnPlayer(player.whoAmI, Mod.Find<ModNPC>("SentientStickgun").Type);
            SoundEngine.PlaySound(SoundID.Roar, player.position);
            return true;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(Mod.Find<ModItem>("EmotionalStickgun").Type);
            recipe.AddIngredient(ItemID.Nanites, 99);
            recipe.AddTile(TileID.DemonAltar);
            recipe.Register();
        }
    }
}
