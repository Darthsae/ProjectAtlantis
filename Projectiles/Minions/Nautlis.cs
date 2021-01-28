using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace ProjectAtlantis.Projectiles.Minions
{
	// PurityWisp uses inheritace as an example of how it can be useful in modding.
	// HoverShooter and Minion classes help abstract common functionality away, which is useful for mods that have many similar behaviors.
	// Inheritance is an advanced topic and could be confusing to new programmers, see ExampleSimpleMinion.cs for a simpler minion example.
	public class Nautlis : HoverShooter
	{
		public override void SetStaticDefaults() {
			Main.projPet[projectile.type] = true;
			ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
			ProjectileID.Sets.Homing[projectile.type] = true;
			ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true; //This is necessary for right-click targeting
		}

		public override void SetDefaults() {
			projectile.netImportant = true;
			projectile.width = 58;
			projectile.height = 52;
			projectile.friendly = true;
			projectile.minion = true;
			projectile.minionSlots = 1;
			projectile.penetrate = -1;
			projectile.timeLeft = 18000;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			inertia = 20f;
			shoot = mod.ProjectileType("WaterBolt");
			shootSpeed = 12f;
		}

		public override void CheckActive() {
			Player player = Main.player[projectile.owner];
			PASSPlayer modPlayer = player.GetModPlayer<PASSAtlantisPlayer>();
			if (player.dead) {
				modPlayer.NautlisMinion = false;
			}
			if (modPlayer.NautlisMinion) { // Make sure you are resetting this bool in ModPlayer.ResetEffects. See ExamplePlayer.ResetEffects
				projectile.timeLeft = 2;
			}
		}
	}
}
