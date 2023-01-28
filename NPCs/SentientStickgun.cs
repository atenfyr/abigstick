using System;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ABigStick.NPCs {
    public static class UsefulFunctions {
        public static NPC FindNearestNPC(Vector2 pos, int maxDistance) {
            NPC nearest = null;
            float oldDist = 1001;
            float newDist = 1000;
            for (int i = 0; i < Main.npc.Length - 1; i++) {
                if (Main.npc[i].friendly == true || Main.npc[i].active == false || Main.npc[i].dontTakeDamage) continue;                
                if (nearest == null) {
                    newDist = Vector2.Distance(pos, Main.npc[i].position);
                    if (newDist < maxDistance) nearest = Main.npc[i];
                } else {
                    oldDist = Vector2.Distance(pos, nearest.position);
                    newDist = Vector2.Distance(pos, Main.npc[i].position);
                    if (newDist < maxDistance && newDist < oldDist) nearest = Main.npc[i];
                }
            }
            return nearest;
        }
    }

    public class SentientStick : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Sentient Stick");
            Tooltip.SetDefault("'Seems to have ideas of its own'");
        }

        public override string Texture { get { return "ABigStick/Items/SentientStick"; } }

        public override void SetDefaults() {
            Item.damage = 35;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 4;
            Item.height = 20;
            Item.consumable = true;
            Item.knockBack = 2f;
            Item.value = 7500;
            Item.shoot = Mod.Find<ModProjectile>("SentientStick2").Type;
            Item.ammo = Mod.Find<ModItem>("StickItem").Type;
            Item.maxStack = 999;
            Item.rare = 11;
        }
    }

    public class SentientStick2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Sentient Stick");
            ProjectileID.Sets.CultistIsResistantTo[Projectile.type] = true;
        }

        public override void AutoStaticDefaults() {
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/SentientStick");
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
        }

        public override void AI() {
            NPC target = UsefulFunctions.FindNearestNPC(Projectile.Center, 1000);
            if (target != null) {
                Vector2 newVelocity = (target.Center - Projectile.Center).RotatedByRandom(MathHelper.ToRadians(10));
                newVelocity *= 20f / (float)Math.Sqrt(newVelocity.X * newVelocity.X + newVelocity.Y * newVelocity.Y);
                Projectile.velocity.X -= (Projectile.velocity.X-newVelocity.X)/10;
                Projectile.velocity.Y -= (Projectile.velocity.Y-newVelocity.Y)/10;
            }
            Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.ToRadians(90);
        }
    }
    
    public class BossLunar : ModProjectile {
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
            Projectile.friendly = false;
            Projectile.hostile = true;
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

    public class BossTears : ModProjectile {
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
            Projectile.friendly = false;
            Projectile.hostile = true;
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

    public class BossLuminite : ModProjectile {
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
            Projectile.friendly = false;
            Projectile.hostile = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 999;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool cri) {
            Projectile.damage = Projectile.damage + 5;
        }
    }

    public class BossCosmilite : ModProjectile {
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
            Projectile.friendly = false;
            Projectile.hostile = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = 1;
        }
    }

    public class BossRainbow : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Rainbow Stick");
        }

        public override void AutoStaticDefaults() {
            TextureAssets.Projectile[Projectile.type] = ModContent.Request<Texture2D>("ABigStick/Items/RainbowStickProjectile");
        }

        public override void SetDefaults() {
            Projectile.width = 20;
            Projectile.height = 4;
            Projectile.aiStyle = 1;
            Projectile.friendly = false;
            Projectile.hostile = true;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.penetrate = -1;
        }

        public override void OnHitPlayer(Player target, int damage, bool crit) {
            target.statLife = 1;
        }
    }

    [AutoloadBossHead]
    public class SentientStickgun : ModNPC {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("A Sentient Stickgun");
        }

        public override void AutoStaticDefaults() {
            TextureAssets.Npc[NPC.type] = ModContent.Request<Texture2D>("ABigStick/Items/6/Crit");
        }

        public override void SetDefaults() {
            NPC.width = 80;
            NPC.height = 33;
            NPC.scale = 2f;
            NPC.aiStyle = -1;
            NPC.damage = 75;
            NPC.defense = 20;
            NPC.lifeMax = 75000;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.knockBackResist = 0f;
            NPC.noGravity = true;
            NPC.noTileCollide = true;
            NPC.lavaImmune = true;
            NPC.timeLeft = NPC.activeTime * 30;
            NPC.boss = true;
            NPC.value = 30000f;
            NPC.buffImmune[31] = true;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale) {
            NPC.lifeMax = (int)(NPC.lifeMax * 0.75f * bossLifeScale);
            NPC.damage = (int)(NPC.damage * 0.6f);
        }

        public override void AI() {
            // calculate target
            NPC.TargetClosest(true);
            Player target = Main.player[NPC.target];

            // fly away if everyone's dead
            if (!target.active || target.dead) {
                NPC.TargetClosest(true);
                target = Main.player[NPC.target];
                if (!target.active || target.dead) {
                    NPC.velocity = new Vector2(0f, -10f);
                    if (NPC.timeLeft > 10) NPC.timeLeft = 10;
                    return;
                }
            }

            // rotate towards target
            Vector2 properDirection = new Vector2((float)(target.Center.X-NPC.Center.X), (float)(target.Center.Y-NPC.Center.Y));
            NPC.rotation = (float)(Math.Atan2(properDirection.Y, properDirection.X));

            // fire bullets where it's facing
            if (Main.netMode != 1) {
                NPC.ai[0]--;
                if (NPC.ai[0] <= 0f) {
                    float fireSpeed = 3f;
                    bool revengeOn = false;

                    if (Main.expertMode) fireSpeed = (Main.rand.NextBool(2))?3f:2f;
                    // check if we're in revengeance mode (calamity)
                    ModLoader.TryGetMod("CalamityMod", out Mod calamityMod);
                    if (calamityMod != null) {
                        revengeOn = (bool)calamityMod.Call("DifficultyActive", "revengeance");
                        if (revengeOn == true) {
                            fireSpeed = 2f;
                        }
                    }

                    String projectileType = "BossLunar";;
                    int projectileDamage = 55;
                    if (NPC.ai[1] == 2f) {
                        projectileType = "BossTears";
                        projectileDamage = 40;
                    } else if (NPC.ai[1] == 3f) {
                        projectileType = "BossLuminite";
                        projectileDamage = 35;
                    } else if (NPC.ai[1] == 4f) {
                        projectileType = "BossCosmilite";
                        projectileDamage = 95;
                    }

                    if (Main.expertMode && Main.rand.NextBool(12)) {
                        projectileType = "BossRainbow";
                        projectileDamage = 1;
                    }

                    float lifePercentage = (float)NPC.life/(float)NPC.lifeMax;
                    if (lifePercentage <= 0.25f && revengeOn) { // 25% health
                        NPC.ai[1] = 4f;
                    } else if (lifePercentage <= 0.45f) { // 35% health
                        NPC.ai[1] = 1f;
                    } else if (lifePercentage <= 0.55f) { // 55% health
                        NPC.ai[1] = 2f;
                    } else {
                        NPC.ai[1] = 3f;
                    }

                    NPC.ai[0] = fireSpeed;
                    SoundEngine.PlaySound(SoundID.Item40, NPC.Center);
                    Vector2 projectileVelocity = properDirection.RotatedByRandom(MathHelper.ToRadians(10));
                    int a = Projectile.NewProjectile(null, NPC.Center.X, NPC.Center.Y, projectileVelocity.X, projectileVelocity.Y, Mod.Find<ModProjectile>(projectileType).Type, projectileDamage, 3f);
                    if (revengeOn || (Main.expertMode && Main.rand.NextBool(2))) Main.projectile[a].extraUpdates = 1;
                }
            }

            // chase target while twitching
            if (target.Distance(NPC.Center) > 250f) {
                Vector2 newVelocity = (target.Center - NPC.Center).RotatedByRandom(MathHelper.ToRadians(180));
                newVelocity *= 10f / (float)Math.Sqrt(newVelocity.X * newVelocity.X + newVelocity.Y * newVelocity.Y);
                NPC.velocity = newVelocity;
            } else {
                NPC.velocity = new Vector2(0f, 10f).RotatedByRandom(MathHelper.ToRadians(360));
            }
        }

        public override void BossLoot(ref string name, ref int potionType) {
            name = "A Sentient Stickgun";
            potionType = ItemID.GreaterHealingPotion;
        }

        public override void OnKill() {
            for (int i = 0; i < 3; i++) {
                Item.NewItem(null, NPC.getRect(), Mod.Find<ModItem>("SentientStick").Type, Main.rand.Next(500, 1000));
            }
            Item.NewItem(null, NPC.getRect(), Mod.Find<ModItem>("BigStick").Type);
        }
    }
}
