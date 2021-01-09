using ProjectAtlantis.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectAtlantis.Items.Materials
{
    public class AtlanticOre : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.value = 300;
            item.rare = ItemRarityID.White;
            item.createTile = ModContent.TileType<AtlanticOreTile>();
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FishingSeaweed);
            recipe.AddTile(mod.TileType("SeaInfuserTile"));
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TinCan);
            recipe.AddTile(mod.TileType("SeaInfuserTile"));
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.OldShoe);
            recipe.AddTile(mod.TileType("SeaInfuserTile"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}