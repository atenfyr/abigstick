using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ABigStick.Items {
    public class BigStick : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("A Big Stick");
            Tooltip.SetDefault("'Larger than it should be'");
        }

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/Swords/ABigStick");
        }

        public override void SetDefaults() {
            item.damage = 140;
            item.melee = true;
            item.width = 120;
            item.height = 120;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 100;
            item.value = 0;
            item.rare = 10;
            item.crit = 30;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("StickgunServant");
            item.shootSpeed = 8f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
            Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
            for (int i = 0; i <= 3; i++) {
                Dust.NewDust(target, 0, 0, 138, 0f, 0f, 0, new Color(159,105,15), 1f);
            }
            Projectile.NewProjectile(target.X, target.Y, 0f, 0f, type, 0, knockBack, player.whoAmI);
            return false;
        }
    }
}
