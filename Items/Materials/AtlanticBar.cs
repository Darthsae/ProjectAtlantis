using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectAtlantis.Items.Materials
{
    public class AtlanticBar : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = 900;
            item.rare = ItemRarityID.White;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("AtlanticOre"), 3);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}