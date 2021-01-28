using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PASS.Projectiles
{
	public class BettaBubble : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Betta Bubble");
		}

		public override void SetDefaults()
		{
			projectile.width = 26;
			projectile.height = 26;
			projectile.aiStyle = -1;
			projectile.friendly = true;
			projectile.penetrate = 2;
			projectile.ignoreWater = true;
			projectile.timeLeft = 180;
			aiType = -1;
		}

		public override bool OnTileCollide(Vector2 velocityChange)
        {
            if (projectile.velocity.X != velocityChange.X)
            {
                projectile.velocity.X = -velocityChange.X/2; //Goes in the opposite direction with half of its x velocity
            }
            if (projectile.velocity.Y != velocityChange.Y)
            {
                projectile.velocity.Y = -velocityChange.Y/2; //Goes in the opposite direction with half of its y velocity
            }
            return false;
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

		public override void AI() {
			projectile.localAI[0] += 1f;
					 if (projectile.localAI[0] > 3f)
					 {
							 projectile.alpha = 0;
					 }
					 if (projectile.ai[0] >= 20f)
					 {
							 projectile.ai[0] = 20f;
							 projectile.velocity.Y += 0.075f;
					 }
					 if (Main.myPlayer == projectile.owner)
					 {
							 if (projectile.ai[1] >= 0f)
							 {
									 projectile.ai[1] += 1f;
							 }
							 if (projectile.ai[1] > 179f)
							 {
									 projectile.ai[1] = -1000f;
									 float scaleFactor4 = projectile.velocity.Length();
									 Vector2 velocity = projectile.velocity;
									 velocity.Normalize();
									 int num161 = Main.rand.Next(2, 4);
									 if (Main.rand.Next(4) == 0)
									 {
											 num161++;
									 }
									 for (int num162 = 0; num162 < num161; num162++)
									 {
											 Vector2 vector12 = new Vector2((float)Main.rand.Next(-100, 101), (float)Main.rand.Next(-100, 101));
											 vector12.Normalize();
											 vector12 += velocity * 2f;
											 vector12.Normalize();
											 vector12 *= scaleFactor4;
											 Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, vector12.X, vector12.Y, projectile.type, projectile.damage, projectile.knockBack, projectile.owner, 0f, -1000f);
									 }
							 }
					 }
		}

		// Additional hooks/methods here.
	}
}
