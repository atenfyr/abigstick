using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ABigStick.Items {
    /*
        It's quicker not to ask
    */
    public class CardioCrystal : ModItem {
        public override string Name { get { return "CardioCrystal"; } }

        public override void SetStaticDefaults() {
            // DisplayName.SetDefault("Cardio Crystal");
            // Tooltip.SetDefault("Increases max life by 50%\n30 second duration\n'Dancing to the beat of your heart'");
        }

        public override void SetDefaults() {
            Item.width = 64;
            Item.height = 64;
            Item.maxStack = 3;
            Item.useAnimation = 45;
            Item.useTime = 45;
            Item.useStyle = 4;
            Item.consumable = true;
            Item.rare = 7;
        }

        public override bool? UseItem(Player player)/* tModPorter Suggestion: Return null instead of false */ {
            player.AddBuff(Mod.Find<ModBuff>("Cardio").Type, 30 * 60);
            return true;
        }

        public override void AddRecipes() {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.LifeFruit);
            recipe.AddIngredient(ItemID.Sunglasses);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
