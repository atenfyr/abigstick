using System;
using Terraria;
using Terraria.ModLoader;

namespace ABigStick {
	class ABigStick : Mod {
		public ABigStick() {
			Properties = new ModProperties() {
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

        public override void AddRecipeGroups() {
    	    RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Stick", new int[] {
    		    this.ItemType("StickItem"),
    		    this.ItemType("HighVelocityStickItem"),
                this.ItemType("PenetratingStickItem"),
                this.ItemType("StickH"),
                this.ItemType("StickCo"),
                this.ItemType("StickCr"),
                this.ItemType("StickBo"),
                this.ItemType("StickL"),
                this.ItemType("StickD"),
                this.ItemType("StickM"),
                this.ItemType("StickK"),
                this.ItemType("StickAten"),
                this.ItemType("StickMoon"),
                this.ItemType("AetherStickItem"),
                this.ItemType("StickCosmilite"),
                this.ItemType("SentientStick")
    	    });
    	    RecipeGroup.RegisterGroup("ABigStick:Sticks", group);
        }
	}
}
