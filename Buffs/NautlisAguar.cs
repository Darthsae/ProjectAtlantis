using Terraria;
using Terraria.ModLoader;

namespace ProjectAtlantis.Buffs
{
	public class NautlisAguar : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("NautlisAguar");
			Description.SetDefault("The Nautlis is empowered");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}
