using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectAtlantis.Items.Weapons
{
    public class PufferfishFlail : ModItem
    {
			public override void SetStaticDefaults()
			{
				DisplayName.SetDefault("Pufferfish Flail"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
				Tooltip.SetDefault("Pufferfish deliver extra POW.");
			}
        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 34;
            item.value = 100;
            item.rare = 10;

            item.noMelee = true; // Makes sure that the animation when using the item doesn't hurt NPCs.
            item.useStyle = 5; // Set the correct useStyle.
            item.useAnimation = 40; // Determines how long the animation lasts.
            item.useTime = 40; // Determines how fast you can use this weapon (a lower value results in a faster use time).
            item.knockBack = 7.5F;
            item.damage = 10;
            item.scale = 1.1F;
            item.noUseGraphic = true; // Do not use the item graphic when using the item (we just want the ball to spawn).
            item.shoot = mod.ProjectileType("PufferPowBall");
            item.shootSpeed = 20F;
            item.melee = true; // Deals melee damage.
            item.channel = true; // We can keep the left mouse button down when trying to keep using this weapon.
        }
    }
}
