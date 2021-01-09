using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ProjectAtlantis.Projectiles;

namespace ProjectAtlantis.Items.Weapons
{
    public class KnightSwordfish : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a swordfish beam");
        }

        public override void SetDefaults()
        {
            item.damage = 30;
            item.melee = true;
            item.useTime = 40;
            item.width = 30;
            item.height = 30;
            item.useAnimation = 20;
            item.knockBack = 5;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.maxStack = 1;
            item.value = 50000;
            item.rare = ItemRarityID.LightRed;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = ModContent.ProjectileType<KnightSwordfishProjectile>();
            item.shootSpeed = 8f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Swordfish);
            recipe.AddIngredient(mod.ItemType("AtlanticBar"), 10);
            recipe.AddIngredient(ItemID.CobaltBar, 10);
            recipe.AddTile(mod.TileType("SeaInfuserTile"));
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Swordfish);
            recipe.AddIngredient(mod.ItemType("AtlanticBar"), 10);
            recipe.AddIngredient(ItemID.PalladiumBar, 10);
            recipe.AddTile(mod.TileType("SeaInfuserTile"));
            recipe.SetResult(this);
            recipe.AddRecipe();
            
        }
    }
}