using Terraria.ModLoader;

namespace ABigStick
{
	class ABigStick : Mod
	{
		public ABigStick()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
