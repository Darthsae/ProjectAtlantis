using Terraria;
using Terraria.ModLoader;

namespace PASS.Buffs
{
	public class Nautlis : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Nautlis");
			Description.SetDefault("The Nautlis will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			PASSPlayer modPlayer = player.GetModPlayer<PASSPlayer>();
			if (player.ownedProjectileCounts[mod.ProjectileType("Nautlis")] > 0) {
				modPlayer.NautlisMinion = true;
			}
			if (!modPlayer.NautlisMinion) {
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else {
				player.buffTime[buffIndex] = 18000;
			}
		}
	}
}
