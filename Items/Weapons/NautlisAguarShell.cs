using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PASS.Items
{
    public class NautlisAguarShell : ModItem
    {
      public override void SetStaticDefaults()
      {
        DisplayName.SetDefault("NautlisAguarShell"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
        Tooltip.SetDefault("NAGS.");
      }

      public override void SetDefaults()
      {
        item.width = 30;
        item.height = 24;
        item.value = 100;
        item.rare = 3;
        item.accessory = true;
      }

      public override void UpdateEquip(Player player)
      {
        player.AddBuff(mod.BuffType("NautlisAguar"), 2);
      }
    }
}
