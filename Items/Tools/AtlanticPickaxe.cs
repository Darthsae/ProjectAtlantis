using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectAtlantis.Items.Tools
{
    public class AtlanticPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Can mine Meteorite");
        }
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 1;
            item.value = 2500;
            item.rare = ItemRarityID.White;
            item.useAnimation = 19;
            item.useTime = 19;
            item.pick = 57;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.damage = 6;
            item.melee = true;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("AtlanticBar"), 12);
            recipe.AddRecipeGroup("Wood", 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}