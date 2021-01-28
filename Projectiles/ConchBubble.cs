using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PASS.Projectiles
{
	public class ConchBubble : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Conch Bubble");
		}

		public override void SetDefaults()
		{
			projectile.width = 26;
			projectile.height = 26;
			projectile.aiStyle = -1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			aiType = -1;
		}

		public override void Kill(int timeLeft)
		{
			for (int i = 0; i < 4; i++) {
				int dustType = Main.rand.Next(103, 103);
				int dustIndex = Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("BettaBubbleDust"));
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.1f;
			}
		}

		public override void AI()
		{
    //Making player variable "p" set as the projectile's owner
    Player player = Main.player[projectile.owner];

    //Factors for calculations
    double deg = (double) projectile.ai[1]; //The degrees, you can multiply projectile.ai[1] to make it orbit faster, may be choppy depending on the value
    double rad = deg * (Math.PI / 180); //Convert degrees to radians
    double dist = 64; //Distance away from the player

    /*Position the player based on where the player is, the Sin/Cos of the angle times the /
    /distance for the desired distance away from the player minus the projectile's width   /
    /and height divided by two so the center of the projectile is at the right place.     */
    projectile.position.X = player.Center.X - (int)(Math.Cos(rad) * dist) - projectile.width/2;
    projectile.position.Y = player.Center.Y - (int)(Math.Sin(rad) * dist) - projectile.height/2;

    //Increase the counter/angle in degrees by 1 point, you can change the rate here too, but the orbit may look choppy depending on the value
    projectile.ai[1] += 1f;
	}

		// Additional hooks/methods here.
	}
}
