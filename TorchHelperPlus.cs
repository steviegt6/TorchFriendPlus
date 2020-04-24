using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace TorchHelperPlus
{
	class TorchHelperPlus : Mod
	{
		public TorchHelperPlus()
		{
		}
public override void AddRecipeGroups()
        {
            RecipeGroup torchMaterialsPlus = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Stone/Dirt/Similar Block", new int[]
            {
                /*
                ItemID.DirtBlock,
                ItemID.SnowBlock,
                ItemID.SlushBlock,
                ItemID.SiltBlock,
                ItemID.SandBlock,
                ItemID.AshBlock,
                ItemID.AsphaltBlock,
                ItemID.BoneBlock,
                ItemID.ClayBlock,
                ItemID.Cloud,
                ItemID.CrimstoneBlock,
                ItemID.CrimsandBlock,
                ItemID.CrystalBlock,
                ItemID.EbonsandBlock,
                ItemID.EbonstoneBlock,
                ItemID.FleshBlock,
                ItemID.GraniteBlock,
                ItemID.HoneyBlock,
                ItemID.IceBlock,
                ItemID.MarbleBlock,
                ItemID.MudBlock,
                ItemID.PearlsandBlock,
                ItemID.PearlstoneBlock,
                ItemID.PinkIceBlock,
                ItemID.RedIceBlock,
                ItemID.SandBlock,
                ItemID.SiltBlock,
                ItemID.SlushBlock,
                ItemID.SnowBlock,
                ItemID.StoneBlock,
                ItemID.TitanstoneBlock
                */
                ItemID.MudstoneBlock,
                ItemID.LunarBlockVortex,
                ItemID.LunarBlockStardust,
                ItemID.LunarBlockNebula,
                ItemID.ActiveStoneBlock,
                ItemID.InactiveStoneBlock,
                ItemID.BubblegumBlock,
                ItemID.ChlorophyteBrick,
                ItemID.CobaltBrick,
                ItemID.CopperBrick,
                ItemID.CrimtaneBrick,
                ItemID.GoldBrick,
                ItemID.SilverBrick,
                ItemID.GrayBrick,
                ItemID.GrayStucco,
                ItemID.GreenStucco,
                ItemID.HellstoneBrick,
                ItemID.IridescentBrick,
                ItemID.LunarBrick,
                ItemID.MeteoriteBrick,
                ItemID.LunarBlockSolar,
                ItemID.MythrilBrick,
                ItemID.PalladiumColumn,
                ItemID.PlatinumBrick,
                ItemID.ShroomitePlating,
                ItemID.TinBrick,
                ItemID.TungstenBrick,
                ItemID.CopperPlating,
                ItemID.TinPlating,
                ItemID.SunplateBlock,
                ItemID.StoneSlab,
                ItemID.Sandstone,
                ItemID.CorruptSandstone,
                ItemID.CrimsonSandstone,
                ItemID.HallowSandstone,
                ItemID.HardenedSand,
                ItemID.CorruptHardenedSand,
                ItemID.CrimsonHardenedSand,
                ItemID.HallowHardenedSand,
                ItemID.PurpleIceBlock,
                ItemID.RedStucco,
                ItemID.YellowStucco,
                ItemID.GrayBrick,
                ItemID.RedBrick,
                ItemID.EbonstoneBrick,
                ItemID.PearlstoneBrick,
                ItemID.SandstoneBrick,
                ItemID.SnowBrick,
                ItemID.IceBrick,
                ItemID.MartianConduitPlating,
                ItemID.CrimtaneBrick,
                ItemID.DemoniteBrick,
                ItemID.MeteoriteBrick,
                ItemID.ObsidianBrick,
                ItemID.HellstoneBrick,
                ItemID.CobaltBrick,
                ItemID.MythrilBrick,
                ItemID.MythrilBrick,
                ItemID.ChlorophyteBrick,
                3469, //Forgot the source code name lol (Luminite Brick)
                ItemID.RainbowBrick,
                ItemID.BlueBrick,
                ItemID.PinkBrick,
                ItemID.PinkBrick,
                ItemID.LihzahrdBrick,
                ItemID.Hay,
                ItemID.Cactus,
                ItemID.Pumpkin,
                ItemID.Cloud,
                ItemID.RainCloud,
                ItemID.SnowCloudBlock,
                ItemID.SunplateBlock,
                ItemID.HoneyBlock,
                ItemID.CrispyHoneyBlock,
                ItemID.Cobweb,
                ItemID.CopperOre,
                ItemID.TinOre,
                ItemID.IronOre,
                ItemID.LeadOre,
                ItemID.SilverOre,
                ItemID.TungstenOre,
                ItemID.GoldOre,
                ItemID.PlatinumOre,
                ItemID.Meteorite,
                ItemID.DemoniteOre,
                ItemID.CrimtaneOre,
                ItemID.Obsidian,
                ItemID.Hellstone,
                ItemID.CobaltOre,
                ItemID.PalladiumOre,
                ItemID.MythrilOre,
                ItemID.OrichalcumOre,
                ItemID.AdamantiteOre,
                ItemID.TitaniumOre,
                ItemID.ChlorophyteOre,
                3460, //Luminite ore
                ItemID.Glass,
                ItemID.PalladiumColumn,
                ItemID.BubblegumBlock,
                ItemID.AdamantiteBeam,
                ItemID.SlimeBlock,
                ItemID.FrozenSlimeBlock,
                ItemID.PinkSlimeBlock,
                ItemID.AsphaltBlock,
                ItemID.FleshBlock,
                ItemID.StoneSlab,
                ItemID.SandstoneSlab,
                ItemID.CrystalBlock,
                ItemID.LavafallBlock,
                ItemID.WaterfallBlock,
                ItemID.HoneyfallBlock,
                ItemID.SandFallBlock,
                ItemID.SnowFallBlock,
                ItemID.ConfettiBlock,
                ItemID.ConfettiBlock,
                357, //Smooth Marble
                369, //Smooth Granite
                ItemID.AmethystGemsparkBlock,
                ItemID.TopazGemsparkBlock,
                ItemID.SapphireGemsparkBlock,
                ItemID.EmeraldGemsparkBlock,
                ItemID.RubyGemsparkBlock,
                ItemID.DiamondGemsparkBlock,
                ItemID.AmberGemsparkBlock
            });
            RecipeGroup.RegisterGroup("TorchFriendPlus:TorchMaterialsPlus", torchMaterialsPlus);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe1 = new ModRecipe(this);
            recipe1.AddIngredient(ItemID.Bottle);
            recipe1.AddIngredient(ItemID.MechanicalSkull);
            recipe1.AddIngredient(ItemID.SoulofSight, 10);
            recipe1.AddIngredient(ItemID.Ectoplasm, 5);
            recipe1.AddTile(TileID.MythrilAnvil);
            recipe1.SetResult(ItemID.WispinaBottle);
            recipe1.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(this);
            recipe2.AddIngredient(ItemID.SuspiciousLookingEye);
            recipe2.AddIngredient(ItemID.MechanicalEye);
            recipe2.AddIngredient(ItemID.SoulofSight, 10);
            recipe2.AddIngredient(ItemID.LunarBar, 10);
            recipe2.AddTile(TileID.LunarCraftingStation);
            recipe2.SetResult(ItemID.SuspiciousLookingTentacle);
            recipe2.AddRecipe();

            ModRecipe recipe3 = new ModRecipe(this);
            recipe3.AddIngredient(ItemID.GoldBar, 10);
            recipe3.AddIngredient(ItemID.SpelunkerGlowstick, 1);
            recipe3.AddIngredient(ItemID.Glass, 5);
            recipe3.AddTile(TileID.Anvils);
            recipe3.SetResult(ItemID.MagicLantern);
            recipe3.AddRecipe();

            ModRecipe recipe4 = new ModRecipe(this);
            recipe4.AddIngredient(ItemID.WaterCandle);
            recipe4.AddIngredient(ItemID.SoulofSight, 10);
            recipe4.AddIngredient(ItemID.Ectoplasm, 5);
            recipe4.AddIngredient(ItemID.DefenderMedal, 30);
            recipe4.AddTile(TileID.MythrilAnvil);
            recipe4.SetResult(ItemID.DD2PetGhost);
            recipe4.AddRecipe();

            ModRecipe recipe5 = new ModRecipe(this);
            recipe5.AddIngredient(ItemID.DemoniteBar, 5);
            recipe5.AddIngredient(ItemID.ShadowScale, 15);
            recipe5.AddTile(TileID.MythrilAnvil);
            recipe5.SetResult(ItemID.ShadowOrb);
            recipe5.AddRecipe();

            ModRecipe recipe6 = new ModRecipe(this);
            recipe6.AddIngredient(ItemID.CrimtaneBar, 5);
            recipe6.AddIngredient(ItemID.TissueSample, 15);
            recipe6.AddTile(TileID.MythrilAnvil);
            recipe6.SetResult(ItemID.CrimsonHeart);
            recipe6.AddRecipe();

            ModRecipe recipe7 = new ModRecipe(this);
            recipe7.AddRecipeGroup("TorchFriend:TorchMaterials", 45);
            recipe7.SetResult(ItemID.Torch, 2);
            recipe7.AddRecipe();

            ModRecipe recipe8 = new ModRecipe(this);
            recipe8.AddRecipeGroup("TorchFriendPlus:TorchMaterialsPlus", 25);
            recipe8.SetResult(ItemID.Torch, 1);
            recipe8.AddRecipe();

            ModRecipe recipe9 = new ModRecipe(this);
            recipe9.AddRecipeGroup("TorchFriendPlus:TorchMaterialsPlus", 45);
            recipe9.SetResult(ItemID.Torch, 2);
            recipe9.AddRecipe();
        }
	}
}