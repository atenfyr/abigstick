using System;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ABigStick.Items {
    public class ServantStick : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Sentient Stick");
        }

        public override void AutoStaticDefaults() {
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/SentientStick");
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
            Projectile.extraUpdates = 1;
        }
    }

    public class StickgunServant : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("A Stickgun Servant");
        }

        public override void AutoStaticDefaults() {
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/Swords/Turret");
        }

        public override void SetDefaults() {
            Projectile.width = 44;
            Projectile.height = 68;
            Projectile.friendly = true;
        }

        public override void AI() {
            // calculate target
            NPC target = NPCs.UsefulFunctions.FindNearestNPC(Projectile.Center, 9999);

            if (target != null) {
                // rotate towards target
                Vector2 properDirection = new Vector2((float)(target.Center.X-Projectile.Center.X), (float)(target.Center.Y-Projectile.Center.Y));
                Projectile.rotation = (float)((Math.Atan2(properDirection.Y, properDirection.X)-(Math.PI/2))%(Math.PI*2));

                // fire where it's facing
                Projectile.ai[0]--;
                if (Projectile.ai[0] <= 0f) {
                    Projectile.ai[0] = 20f;
                    SoundEngine.PlaySound(SoundID.Item36, Projectile.Center);
                    if (Main.netMode != 1) {
                        for (int i = 0; i < 3; i++) {
                            Vector2 projectileVelocity = properDirection.RotatedByRandom(MathHelper.ToRadians(10));
                            Projectile.NewProjectile(null, Projectile.Center.X, Projectile.Center.Y, projectileVelocity.X, projectileVelocity.Y, Mod.Find<ModProjectile>("ServantStick").Type, 75, 3f, Main.myPlayer);
                        }
                    }
                }

                // commit suicide once we're done
                if (Projectile.ai[0] == 1f) {
                    for (int i = 0; i <= 3; i++) {
                        Dust.NewDust(Projectile.position, 0, 0, 138, 0f, 0f, 0, new Color(159,105,15), 1f);
                    }
                    Projectile.Kill();
                }
            } else {
                for (int i = 0; i <= 3; i++) {
                    Dust.NewDust(Projectile.position, 0, 0, 138, 0f, 0f, 0, new Color(159,105,15), 1f);
                }
                Projectile.Kill();
            }
        }
    }
}
