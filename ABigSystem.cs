using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ABigStick
{
    public class ABigSystem : ModSystem
    {
        public static RecipeGroup StickRecipeGroup;

        public override void Unload()
        {
            StickRecipeGroup = null;
        }

        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Stick", new int[] {
                Mod.Find<ModItem>("StickItem").Type,
                Mod.Find<ModItem>("HighVelocityStickItem").Type,
                Mod.Find<ModItem>("PenetratingStickItem").Type,
                Mod.Find<ModItem>("StickH").Type,
                Mod.Find<ModItem>("StickCo").Type,
                Mod.Find<ModItem>("StickCr").Type,
                Mod.Find<ModItem>("StickBo").Type,
                Mod.Find<ModItem>("StickL").Type,
                Mod.Find<ModItem>("StickD").Type,
                Mod.Find<ModItem>("StickM").Type,
                Mod.Find<ModItem>("StickK").Type,
                Mod.Find<ModItem>("StickAten").Type,
                Mod.Find<ModItem>("StickMoon").Type,
                Mod.Find<ModItem>("AetherStickItem").Type,
                Mod.Find<ModItem>("StickCosmilite").Type,
                Mod.Find<ModItem>("SentientStick").Type
            });
            RecipeGroup.RegisterGroup("ABigStick:Sticks", group);
            StickRecipeGroup = group;
        }
    }
}
