using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectAtlantis.Items.Weapons
{
    public class AtlanticShortsword : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 1;
            item.value = 1800;
            item.rare = ItemRarityID.White;
            item.damage = 12;
            item.melee = true;
            item.useTime = 10;
            item.knockBack = 5;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.Stabbing;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("AtlanticBar"), 7);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}