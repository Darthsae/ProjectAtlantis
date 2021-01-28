using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PASS.Items
{
	public class KillerWhale : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Killer Whale"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Waaoaoooooooooooaoaoo");
		}

		public override void SetDefaults()
		{
			item.width = 66;
			item.height = 28;
			item.damage = 40;
			item.useTime = 5;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 100;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
      item.shoot = 14;
      item.shootSpeed = 10f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Megashark);
			recipe.AddIngredient(mod.ItemType("AtlanticBar"), 20);
			recipe.AddTile(mod.TileType("SeaInfuser"));
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}
