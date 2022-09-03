using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

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

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/SentientStick");
        }

        public override void SetDefaults() {
            item.damage = 35;
            item.ranged = true;
            item.width = 4;
            item.height = 20;
            item.consumable = true;
            item.knockBack = 2f;
            item.value = 7500;
            item.shoot = mod.ProjectileType("SentientStick2");
            item.ammo = mod.ItemType("StickItem");
            item.maxStack = 999;
            item.rare = 11;
        }
    }

    public class SentientStick2 : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Sentient Stick");
            ProjectileID.Sets.Homing[projectile.type] = true;
        }

        public override void AutoStaticDefaults() {
            Main.projectileTexture[projectile.type] = ModLoader.GetTexture("ABigStick/Items/SentientStick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 4;
            projectile.aiStyle = -1;
            projectile.friendly = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = false;
            projectile.ranged = true;
            projectile.penetrate = 1;
        }

        public override void AI() {
            NPC target = UsefulFunctions.FindNearestNPC(projectile.Center, 1000);
            if (target != null) {
                Vector2 newVelocity = (target.Center - projectile.Center).RotatedByRandom(MathHelper.ToRadians(10));
                newVelocity *= 20f / (float)Math.Sqrt(newVelocity.X * newVelocity.X + newVelocity.Y * newVelocity.Y);
                projectile.velocity.X -= (projectile.velocity.X-newVelocity.X)/10;
                projectile.velocity.Y -= (projectile.velocity.Y-newVelocity.Y)/10;
            }
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(90);
        }
    }
    
    public class BossLunar : ModProjectile {
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
            projectile.friendly = false;
            projectile.hostile = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = false;
            projectile.ranged = true;
        }

        public override void Kill(int timeLeft) {
            for (int i = 0; i <= 2; i++) {
                Dust.NewDust(projectile.position, 0, 0, 1, 0f, 0f, 0, new Color(155, 155, 155), 0.75f);
            }
        }
    }

    public class BossTears : ModProjectile {
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
            projectile.friendly = false;
            projectile.hostile = true;
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

    public class BossLuminite : ModProjectile {
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
            projectile.friendly = false;
            projectile.hostile = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = false;
            projectile.ranged = true;
            projectile.penetrate = 999;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool cri) {
            projectile.damage = projectile.damage + 5;
        }
    }

    public class BossCosmilite : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Cosmilite Stick");
        }

        public override void AutoStaticDefaults() {
            Main.projectileTexture[projectile.type] = ModLoader.GetTexture("ABigStick/Items/CosmiliteStick");
        }

        public override void SetDefaults() {
            projectile.width = 20;
            projectile.height = 4;
            projectile.aiStyle = 1;
            projectile.friendly = false;
            projectile.hostile = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = false;
            projectile.ranged = true;
            projectile.penetrate = 1;
        }
    }

    public class BossRainbow : ModProjectile {
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
            projectile.friendly = false;
            projectile.hostile = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.ranged = true;
            projectile.penetrate = -1;
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
            Main.npcTexture[npc.type] = ModLoader.GetTexture("ABigStick/Items/6/Crit");
        }

        public override void SetDefaults() {
            npc.width = 80;
            npc.height = 33;
            npc.scale = 2f;
            npc.aiStyle = -1;
            npc.damage = 75;
            npc.defense = 20;
            npc.lifeMax = 75000;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0f;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.lavaImmune = true;
            npc.timeLeft = NPC.activeTime * 30;
            npc.boss = true;
            npc.value = 30000f;
            npc.buffImmune[31] = true;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale) {
            npc.lifeMax = (int)(npc.lifeMax * 0.75f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
        }

        public override void AI() {
            // calculate target
            npc.TargetClosest(true);
            Player target = Main.player[npc.target];

            // fly away if everyone's dead
            if (!target.active || target.dead) {
                npc.TargetClosest(true);
                target = Main.player[npc.target];
                if (!target.active || target.dead) {
                    npc.velocity = new Vector2(0f, -10f);
                    if (npc.timeLeft > 10) npc.timeLeft = 10;
                    return;
                }
            }

            // rotate towards target
            Vector2 properDirection = new Vector2((float)(target.Center.X-npc.Center.X), (float)(target.Center.Y-npc.Center.Y));
            npc.rotation = (float)(Math.Atan2(properDirection.Y, properDirection.X));

            // fire bullets where it's facing
            if (Main.netMode != 1) {
                npc.ai[0]--;
                if (npc.ai[0] <= 0f) {
                    float fireSpeed = 3f;
                    bool revengeOn = false;

                    if (Main.expertMode) fireSpeed = (Main.rand.NextBool(2))?3f:2f;
                    // check if we're in revengeance mode (calamity)
                    Mod calamityMod = ModLoader.GetMod("CalamityMod");
                    if (calamityMod != null) {
                        ModWorld calamityWorld = calamityMod.GetModWorld("CalamityWorld");
                        revengeOn = (bool)calamityWorld.GetType().GetField("revenge").GetValue(calamityWorld);
                        if (revengeOn == true) {
                            fireSpeed = 2f;
                        }
                    }

                    String projectileType = "BossLunar";
                    int projectileDamage = 55;
                    if (npc.ai[1] == 2f) {
                        projectileType = "BossTears";
                        projectileDamage = 40;
                    } else if (npc.ai[1] == 3f) {
                        projectileType = "BossLuminite";
                        projectileDamage = 35;
                    } else if (npc.ai[1] == 4f) {
                        projectileType = "BossCosmilite";
                        projectileDamage = 95;
                    }

                    if (Main.expertMode && Main.rand.NextBool(12)) {
                        projectileType = "BossRainbow";
                        projectileDamage = 1;
                    }

                    float lifePercentage = (float)npc.life/(float)npc.lifeMax;
                    if (lifePercentage <= 0.25f && revengeOn) { // 25% health
                        npc.ai[1] = 4f;
                    } else if (lifePercentage <= 0.45f) { // 35% health
                        npc.ai[1] = 1f;
                    } else if (lifePercentage <= 0.55f) { // 55% health
                        npc.ai[1] = 2f;
                    } else {
                        npc.ai[1] = 3f;
                    }

                    npc.ai[0] = fireSpeed;
                    Main.PlaySound(SoundID.Item40, (int)npc.Center.X, (int)npc.Center.Y);
                    Vector2 projectileVelocity = properDirection.RotatedByRandom(MathHelper.ToRadians(10));
                    int a = Projectile.NewProjectile(npc.Center.X, npc.Center.Y, projectileVelocity.X, projectileVelocity.Y, mod.ProjectileType(projectileType), projectileDamage, 3f);
                    if (revengeOn || (Main.expertMode && Main.rand.NextBool(2))) Main.projectile[a].extraUpdates = 1;
                }
            }

            // chase target while twitching
            if (target.Distance(npc.Center) > 250f) {
                Vector2 newVelocity = (target.Center - npc.Center).RotatedByRandom(MathHelper.ToRadians(180));
                newVelocity *= 10f / (float)Math.Sqrt(newVelocity.X * newVelocity.X + newVelocity.Y * newVelocity.Y);
                npc.velocity = newVelocity;
            } else {
                npc.velocity = new Vector2(0f, 10f).RotatedByRandom(MathHelper.ToRadians(360));
            }
        }

        public override void BossLoot(ref string name, ref int potionType) {
            name = "A Sentient Stickgun";
            potionType = ItemID.GreaterHealingPotion;
        }

        public override void NPCLoot() {
            for (int i = 0; i < 3; i++) {
                Item.NewItem(npc.getRect(), mod.ItemType("SentientStick"), Main.rand.Next(500, 1000));
            }
            Item.NewItem(npc.getRect(), mod.ItemType("BigStick"));
        }
    }
}
