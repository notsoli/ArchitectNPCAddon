using Terraria.ModLoader.Config;
using System.ComponentModel;

namespace ArchitectNPCAddon
{
	public class ArchitectConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

		[Label("Dirt Price")]
		[Range(0, 10000)]
		[DefaultValue(5)]
		public int dirtPrice;

		[Label("Stone Price")]
		[Range(0, 10000)]
		[DefaultValue(5)]
		public int stonePrice;

		[Header("Sand")]

		[Label("Sand Price")]
		[Range(0, 10000)]
		[DefaultValue(5)]
		public int sandPrice;

		[Label("Hardened Sand Price")]
		[Range(0, 10000)]
		[DefaultValue(5)]
		public int hardenedSandPrice;

		[Label("Desert Fossil Price")]
		[Range(0, 10000)]
		[DefaultValue(500)]
		public int fossilPrice;


		[Header("Wood")]

		[Label("Base Wood Price")]
		[Range(0, 10000)]
		[DefaultValue(10)]
		public int baseWoodPrice;

		[Label("Spooky Wood Price")]
		[Range(0, 10000)]
		[DefaultValue(25)]
		public int spookyWoodPrice;

		[Header("Misc")]

		[Label("Obsidian Price")]
		[Range(0, 10000)]
		[DefaultValue(500)]
		public int obsidianPrice;

		[Label("Granite Price")]
		[Range(0, 10000)]
		[DefaultValue(5)]
		public int granitePrice;

		[Label("Marble Price")]
		[Range(0, 10000)]
		[DefaultValue(5)]
		public int marblePrice;

		[Header("Other")]

		[Label("Hide Duplicate Listings")]
		[Tooltip("Hides the duplicate item listings that are offered elsewhere by the Miner when HelpfulNPCs is installed.")]
		[DefaultValue(true)]
		public bool hideItems;

		public override void OnLoaded()
		{
			ArchitectNPCAddon.architectConfig = this;
		}
	}
}