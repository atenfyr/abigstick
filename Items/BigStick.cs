using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ABigStick.Items {
    public class BigStick : ModItem {
        public override string Name { get { return "BigStick"; } }

        public override string Texture { get { return "ABigStick/Items/Swords/ABigStick"; } }

        public override void SetStaticDefaults() {
            DisplayName.SetDefault("A Big Stick");
            Tooltip.SetDefault("'Larger than it should be'");
        }

        public override void SetDefaults() {
            Item.damage = 140;
            Item.DamageType = DamageClass.Melee/* tModPorter Suggestion: Consider MeleeNoSpeed for no attack speed scaling */;
            Item.width = 120;
            Item.height = 120;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = 1;
            Item.knockBack = 100;
            Item.value = 0;
            Item.rare = 10;
            Item.crit = 30;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.shoot = Mod.Find<ModProjectile>("StickgunServant").Type;
            Item.shootSpeed = 8f;
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) {
            Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
            for (int i = 0; i <= 3; i++) {
                Dust.NewDust(target, 0, 0, 138, 0f, 0f, 0, new Color(159,105,15), 1f);
            }
            Projectile.NewProjectile(null, target.X, target.Y, 0f, 0f, type, 0, knockback, player.whoAmI);
            return false;
        }
    }
}
