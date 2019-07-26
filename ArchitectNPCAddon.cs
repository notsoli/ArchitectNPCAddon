using Terraria.ModLoader;

namespace ArchitectNPCAddon
{
	public class ArchitectNPCAddon : Mod
	{
		internal static ArchitectConfig architectConfig;

		public ArchitectNPCAddon()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true,
			};
		}
	}
}