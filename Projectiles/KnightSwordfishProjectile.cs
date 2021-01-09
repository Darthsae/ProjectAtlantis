using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectAtlantis.Projectiles
{
    public class KnightSwordfishProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swordfish Beam");
        }

        public override void SetDefaults()
        {
            projectile.melee = true;
             projectile.width = 15;
             projectile.height = 15;
             projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.penetrate = 2;
            projectile.maxPenetrate = 2;
            ModContent.ProjectileType<KnightSwordfishProjectile>();
            
        }

        public override void AI()
        {
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2;

            Dust dust1 = Dust.NewDustDirect(projectile.Center, 0, 0, 187, projectile.velocity.X, projectile.velocity.Y, 100, default(Color), 1f);
            dust1.noGravity = true;
            dust1.velocity *= 0.6f;


        }
    }
}