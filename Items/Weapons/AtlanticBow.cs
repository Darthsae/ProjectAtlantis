using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectAtlantis.Items.Weapons
{
    public class AtlanticBow : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 32;
            item.maxStack = 1;
            item.value = 1800;
            item.rare = ItemRarityID.White;
            item.damage = 12;
            item.knockBack = 0;
            item.useTime = 25;
            item.useAnimation = 20;
            item.noMelee = true;
            item.UseSound = SoundID.Item5;
            item.ranged = true;
            item.useAmmo = AmmoID.Arrow;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.shoot = 10;
            item.shootSpeed = 6.6f;
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