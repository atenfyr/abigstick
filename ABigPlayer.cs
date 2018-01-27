using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;

namespace ABigStick {
	public class ABigPlayer : ModPlayer {
        public bool hasTearNet = false;

        public override void ResetEffects() {
            hasTearNet = false;
        }

		public override void clientClone(ModPlayer clientClone) {
			ABigPlayer clone = clientClone as ABigPlayer;
		}

		public override void SyncPlayer(int toWho, int fromWho, bool newPlayer) {
			ModPacket packet = mod.GetPacket();
			packet.Write((byte)player.whoAmI);
			packet.Send(toWho, fromWho);
		}

        /*
		public override TagCompound Save()
		{
			return new TagCompound {
				// {"somethingelse", somethingelse}, // To save more data, add additional lines
				{"score", score},
				{"exampleLifeFruits", exampleLifeFruits},
			};
			//note that C# 6.0 supports indexer initializers
			//return new TagCompound {
			//	["score"] = score
			//};
		} 

		public override void Load(TagCompound tag)
		{
			score = tag.GetInt("score");
			exampleLifeFruits = tag.GetInt("exampleLifeFruits");
		}

		public override void UpdateBadLifeRegen()
		{
			if (eFlames)
			{
				if (player.lifeRegen > 0)
				{
					player.lifeRegen = 0;
				}
				player.lifeRegenTime = 0;
				player.lifeRegen -= 16;
			}
			if (healHurt > 0)
			{
				if (player.lifeRegen > 0)
				{
					player.lifeRegen = 0;
				}
				player.lifeRegenTime = 0;
				player.lifeRegen -= 120 * healHurt;
			}
		}

		public override void ProcessTriggers(TriggersSet triggersSet)
		{
			if (ExampleMod.RandomBuffHotKey.JustPressed)
			{
				int buff = Main.rand.Next(BuffID.Count);
				player.AddBuff(buff, 600);
			}
		}

		public override void UpdateEquips(ref bool wallSpeedBuff, ref bool tileSpeedBuff, ref bool tileRangeBuff)
		{
			// Make sure this condition is the same as the condition in the Buff to remove itself. We do this here instead of in ModItem.UpdateAccessory in case we want future upgraded items to set blockyAccessory
			if (player.townNPCs >= 1 && blockyAccessory)
			{
				player.AddBuff(mod.BuffType<Buffs.Blocky>(), 60, true);
			}
		}
        */
	}
}
