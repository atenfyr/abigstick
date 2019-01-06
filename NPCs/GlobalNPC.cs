using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ABigStick.NPCs {
    public class GlobalNPCs : GlobalNPC {
        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type == NPCID.ArmsDealer) {
                shop.item[nextSlot].SetDefaults(mod.ItemType<Items.StickItem>());
                shop.item[nextSlot].shopCustomPrice = new int?(7);
                nextSlot++;

                shop.item[nextSlot].SetDefaults(mod.ItemType<Items.PenetratingStickItem>());
                shop.item[nextSlot].shopCustomPrice = new int?(15);
                nextSlot++;
            }
        }
    }
}