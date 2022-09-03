using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ABigStick.Items {
    public class ServantStick : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Sentient Stick");
        }

        public override void AutoStaticDefaults() {
            Main.projectileTexture[projectile.type] = ModLoader.GetTexture("ABigStick/Items/SentientStick");
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
            projectile.extraUpdates = 1;
        }
    }

    public class StickgunServant : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("A Stickgun Servant");
        }

        public override void AutoStaticDefaults() {
            Main.projectileTexture[projectile.type] = ModLoader.GetTexture("ABigStick/Items/Swords/Turret");
        }

        public override void SetDefaults() {
            projectile.width = 44;
            projectile.height = 68;
            projectile.friendly = true;
        }

        public override void AI() {
            // calculate target
            NPC target = NPCs.UsefulFunctions.FindNearestNPC(projectile.Center, 9999);

            if (target != null) {
                // rotate towards target
                Vector2 properDirection = new Vector2((float)(target.Center.X-projectile.Center.X), (float)(target.Center.Y-projectile.Center.Y));
                projectile.rotation = (float)((Math.Atan2(properDirection.Y, properDirection.X)-(Math.PI/2))%(Math.PI*2));

                // fire where it's facing
                projectile.ai[0]--;
                if (projectile.ai[0] <= 0f) {
                    projectile.ai[0] = 20f;
                    Main.PlaySound(SoundID.Item36, (int)projectile.Center.X, (int)projectile.Center.Y);
                    if (Main.netMode != 1) {
                        for (int i = 0; i < 3; i++) {
                            Vector2 projectileVelocity = properDirection.RotatedByRandom(MathHelper.ToRadians(10));
                            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, projectileVelocity.X, projectileVelocity.Y, mod.ProjectileType("ServantStick"), 75, 3f, Main.myPlayer);
                        }
                    }
                }

                // commit suicide once we're done
                if (projectile.ai[0] == 1f) {
                    for (int i = 0; i <= 3; i++) {
                        Dust.NewDust(projectile.position, 0, 0, 138, 0f, 0f, 0, new Color(159,105,15), 1f);
                    }
                    projectile.Kill();
                }
            } else {
                for (int i = 0; i <= 3; i++) {
                    Dust.NewDust(projectile.position, 0, 0, 138, 0f, 0f, 0, new Color(159,105,15), 1f);
                }
                projectile.Kill();
            }
        }
    }
}
