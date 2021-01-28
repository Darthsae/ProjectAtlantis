using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PASS.Items
{
    public class Conch : ModItem
    {
      public override void SetStaticDefaults()
      {
        DisplayName.SetDefault("Conch"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
        Tooltip.SetDefault("CONCH.");
      }

      public override void SetDefaults()
      {
        item.width = 30;
        item.height = 24;
        item.damage = 40;
        item.useTime = 40;
        item.useAnimation = 50;
        item.useStyle = 2;
        item.knockBack = 2;
        item.value = 100;
        item.rare = 3;
        item.UseSound = SoundID.Item1;
        item.autoReuse = true;
        item.shoot = mod.ProjectileType("ConchBubble");
        item.shootSpeed = 10f;
      }
    }
}
