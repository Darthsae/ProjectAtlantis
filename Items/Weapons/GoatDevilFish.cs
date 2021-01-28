using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PASS.Items
{
	public class GoatDevilFish : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Goat Eyed Devilfish"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Goats ARE the devil.");
		}

		public override void SetDefaults()
		{
			item.width = 44;
			item.height = 40;
			item.damage = 10;
			item.useTime = 15;
			item.useAnimation = 50;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 100;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
      item.shoot = 85;
      item.shootSpeed = 10f;
		}
	}
}
