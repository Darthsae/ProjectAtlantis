using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectAtlantis.Tiles
{
    public class AtlanticOreTile : ModTile
    {
        public override void SetDefaults()
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 1200;
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Atlantic Ore");
            AddMapEntry(new Color(27, 77, 180), name);

            dustType = 41;
            drop = ModContent.ItemType<Items.Materials.AtlanticOre>();
            soundType = SoundID.Tink;
            soundStyle = 1;
            mineResist = 5f;
            minPick = 35;
        }
    }
}