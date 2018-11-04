using System;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ABigStick.NPCs {
    public class SentientStick : ModItem {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Sentient Stick");
            Tooltip.SetDefault("'Has ideas of its own'");
		}

        public override void AutoStaticDefaults() {
            Main.itemTexture[item.type] = ModLoader.GetTexture("ABigStick/Items/SentientStick");
        }

        public override void SetDefaults() {
			item.damage = 25;
			item.ranged = true;
			item.width = 4;
			item.height = 20;
			item.consumable = true;
			item.knockBack = 2f;
			item.value = 12500;
            item.shoot = mod.ProjectileType("SentientStick2");
            item.ammo = mod.ItemType("StickItem");
            item.maxStack = 999;
            item.rare = 11;
        }
    }

    public class SentientStick2 : ModProjectile {
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
            projectile.penetrate = 1;
        }

        public NPC FindNearest(Vector2 pos) {
            NPC nearest = null;
            float oldDist = 1001;
            float newDist = 1000;
            for (int i = 0; i < Main.npc.Length - 1; i++) {
                if (Main.npc[i].friendly == true) continue;
                if (Main.npc[i].active == false) continue;
                
                if (nearest == null) {
                    newDist = Vector2.Distance(pos, Main.npc[i].position);
                    if (newDist < 1000) nearest = Main.npc[i];
                } else {
                    oldDist = Vector2.Distance(pos, nearest.position);
                    newDist = Vector2.Distance(pos, Main.npc[i].position);
                    if (newDist < 1000 && newDist < oldDist) {
                        nearest = Main.npc[i];
                    }
                }
            }
            return nearest;
        }

        public override void AI() {
            NPC target = FindNearest(projectile.Center);
            if (target != null) {
                Vector2 newVelocity = (target.Center - projectile.Center).RotatedByRandom(MathHelper.ToRadians(10));
                newVelocity *= 20f / (float)Math.Sqrt(newVelocity.X * newVelocity.X + newVelocity.Y * newVelocity.Y);
                
                projectile.velocity = newVelocity;
            }
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(90);
        }
    }
    
    public class BossStick : ModProjectile {
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
            projectile.friendly = false;
            projectile.hostile = true;
			projectile.tileCollide = false;
			projectile.ignoreWater = false;
            projectile.ranged = true;
        }
    }

    [AutoloadBossHead]
	public class Stickgun : ModNPC {
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("A Sentient Stickgun");
		}

		public override void SetDefaults() {
			npc.width = 200;
			npc.height = 35;
			npc.aiStyle = -1;
			npc.damage = 75;
			npc.defense = 20;
			npc.lifeMax = 20000;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0f;
			npc.noGravity = true;
			npc.noTileCollide = true;
            npc.lavaImmune = true;
			npc.timeLeft = NPC.activeTime * 30;
			npc.boss = true;
			npc.value = 30000f;
			npc.npcSlots = 5f;
            npc.buffImmune[31] = true;
		}

		public override void ScaleExpertStats(int numPlayers, float bossLifeScale) {
			npc.lifeMax = (int)(npc.lifeMax * 0.6f * bossLifeScale);
			npc.damage = (int)(npc.damage * 0.6f);
        }

		public override void AI() {
            // calculate target
            npc.TargetClosest(true);
            Player target = Main.player[npc.target];

            // rotate towards target
            Vector2 properDirection = new Vector2((float)(target.Center.X-npc.Center.X), (float)(target.Center.Y-npc.Center.Y));
            npc.rotation = (float)(Math.Atan2(properDirection.Y, properDirection.X));

            // fire bullets where it's facing
            if (Main.netMode != 1) {
                int damage = npc.damage / 2;
                if (Main.expertMode) {
                    damage = (int)(damage / Main.expertDamage);
                }
                Vector2 projectileVelocity = properDirection.RotatedByRandom(MathHelper.ToRadians(10));
                Projectile.NewProjectile(npc.Center.X, npc.Center.Y, projectileVelocity.X, projectileVelocity.Y, mod.ProjectileType("BossStick"), damage, 3f);
            }
            if (Main.rand.NextBool(2)) Main.PlaySound(SoundID.Item40, (int)npc.Center.X, (int)npc.Center.Y);

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
            Item.NewItem(npc.getRect(), mod.ItemType("SentientStick"), Main.rand.Next(100, 501));
        }
	}
}
