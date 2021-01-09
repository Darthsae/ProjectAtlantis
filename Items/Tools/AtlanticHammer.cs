using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectAtlantis.Items.Tools
{
    public class AtlanticHammer : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 9;
            item.melee = true;
            item.width = 32;
            item.width = 32;
            item.useTime = 27;
            item.useAnimation = 30;
            item.hammer = 57;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 5.5f;
            item.value = 2000;
            item.rare = ItemRarityID.White;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("AtlanticBar"), 10);
            recipe.AddRecipeGroup("Wood", 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}