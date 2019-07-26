using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace ArchitectNPCAddon.npcs
{
	[AutoloadHead]
	public class Architect : ModNPC
	{
		public override void SetDefaults()
		{
			npc.GivenName = "Architect";
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 46;
			npc.aiStyle = 7;
			npc.defense = 25;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			Main.npcFrameCount[npc.type] = 25;
			NPCID.Sets.ExtraFramesCount[npc.type] = 9;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 150;
			NPCID.Sets.AttackType[npc.type] = 1;
			NPCID.Sets.AttackTime[npc.type] = 30;
			NPCID.Sets.AttackAverageChance[npc.type] = 10;
			NPCID.Sets.HatOffsetY[npc.type] = 4;
			animationType = NPCID.Guide;
		}

		public override bool CanTownNPCSpawn(int numTownNPCs, int money)
		{
			if (NPC.downedBoss1)
			{
				return true;
			}
			return false;
		}

		public override bool CheckConditions(int left, int right, int top, int bottom)
		{
			return true;
		}

		public override string TownNPCName()
		{
			switch (WorldGen.genRand.Next(8))
			{
				case 0:
					return "Zaha";
				case 1:
					return "Frank";
				case 2:
					return "Ludwig";
				case 3:
					return "Philip";
				case 4:
					return "Renzo";
				case 5:
					return "Cesar";
				case 6:
					return "Louis";
				case 7:
					return "Oscar";
				default:
					return "Archie";
			}
		}

		public override void SetChatButtons(ref string button, ref string button2)
		{
			button = "Building Materials";
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool openShop)
		{
			if (firstButton)
			{
				openShop = true;
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot)
		{
			if (ModLoader.GetMod("HelpfulNPCs") == null && ArchitectNPCAddon.architectConfig.hideItems == true)
			{
				// dirt
				shop.item[nextSlot].SetDefaults(ItemID.DirtBlock);
				shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.dirtPrice;
				nextSlot++;

				// stone
				shop.item[nextSlot].SetDefaults(ItemID.StoneBlock);
				shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.stonePrice;
				nextSlot++;
			}

			shop.item[nextSlot].SetDefaults(ItemID.EbonstoneBlock);
			shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.stonePrice;
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.CrimstoneBlock);
			shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.stonePrice;
			nextSlot++;

			if (Main.hardMode)
			{
				shop.item[nextSlot].SetDefaults(ItemID.PearlstoneBlock);
				shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.stonePrice;
				nextSlot++;
			}

			// sand
			shop.item[nextSlot].SetDefaults(ItemID.SandBlock);
			shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.sandPrice;
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.HardenedSand);
			shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.hardenedSandPrice;
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.EbonsandBlock);
			shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.sandPrice;
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.CorruptHardenedSand);
			shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.hardenedSandPrice;
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.CrimsandBlock);
			shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.sandPrice;
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.CrimsonHardenedSand);
			shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.hardenedSandPrice;
			nextSlot++;

			if (Main.hardMode)
			{
				shop.item[nextSlot].SetDefaults(ItemID.PearlsandBlock);
				shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.sandPrice;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.HallowHardenedSand);
				shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.hardenedSandPrice;
				nextSlot++;
			}

			// fossil
			shop.item[nextSlot].SetDefaults(ItemID.DesertFossil);
			shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.fossilPrice;
			nextSlot++;

			// wood
			shop.item[nextSlot].SetDefaults(ItemID.Wood);
			shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.baseWoodPrice;
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.RichMahogany);
			shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.baseWoodPrice;
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.Ebonwood);
			shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.baseWoodPrice;
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.Shadewood);
			shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.baseWoodPrice;
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.Pearlwood);
			shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.baseWoodPrice;
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.PalmWood);
			shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.baseWoodPrice;
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.DynastyWood);
			nextSlot++;

			if (NPC.downedHalloweenTree)
			{
				shop.item[nextSlot].SetDefaults(ItemID.SpookyWood);
				shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.spookyWoodPrice;
				nextSlot++;
			}

			// misc
			shop.item[nextSlot].SetDefaults(ItemID.Obsidian);
			shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.obsidianPrice;
			nextSlot++;

			if (ModLoader.GetMod("HelpfulNPCs") == null && ArchitectNPCAddon.architectConfig.hideItems == true)
			{
				shop.item[nextSlot].SetDefaults(ItemID.Granite);
				shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.granitePrice;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.Marble);
				shop.item[nextSlot].shopCustomPrice = ArchitectNPCAddon.architectConfig.marblePrice;
				nextSlot++;
			}
		}

		public override string GetChat()
		{
			switch (Main.rand.Next(6))
			{
				case 0:
					return "For some reason, player planted trees can only grow to a certain height. Extensive testing has shown that these high-top trees are not replicable. Preserve them as much as you can! In other words, buy my stuff!";
				case 1:
					return "We now interrupt your gaming experience to ask you to check out Solitaire's other mods. Don't blame me, it's free advertising!";
				case 2:
					return "I like this house, although it could use a third dimension.";
				case 3:
					return "I've gotten a lot of questions as to where my stock comes from. To be completely honest, I don't either.";
				case 4:
					return "Why do people die of thirst? Just use the water duplication glitch, silly!";
				case 5:
					return "Why don't Snatchers drop vines? I mean - they're just a dumbed-down version of the Man Eater.";
				default:
					return "Go kill that eye-looking thing over there.";

			}
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 30;
			knockback = 2f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 5;
			randExtraCooldown = 10;
		}

		public override void DrawTownAttackGun(ref float scale, ref int item, ref int closeness)
		{
			scale = 1f;
			item = 266;
			closeness = 20;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = ProjectileID.SandBallGun;
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 7f;
		}
	}
}