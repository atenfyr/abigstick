using ABigStick.Items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ABigStick.NPCs {
    public class GlobalNPCs : GlobalNPC {
        public override void ModifyShop(NPCShop shop)
        {
            base.ModifyShop(shop);
            if (shop.NpcType == NPCID.ArmsDealer)
            {
                shop.Add<StickItem>();
                shop.Add<PenetratingStickItem>();
            }
        }
    }
}