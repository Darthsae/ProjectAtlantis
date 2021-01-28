using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PASS.Items
{
	public class BettaBubbler : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Betta Bubbler"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A bubble fish.");
		}

		public override void SetDefaults()
		{
			item.width = 42;
			item.height = 44;
			item.useTime = 50;
			item.useAnimation = 50;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 100;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
      item.shoot = mod.ProjectileType("BettaBubble");
      item.shootSpeed = 20f;
		}

		public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 3; // 3 shots
      float rotation = MathHelper.ToRadians(5);//Shoots them in a 45 degree radius. (This is technically 90 degrees because it's 45 degrees up from your cursor and 45 degrees down)
      position += Vector2.Normalize(new Vector2(speedX, speedY)) * 5f; //45 should equal whatever number you had on the previous line
      for (int i = 0; i < numberProjectiles; i++)
      {
        Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Vector for spread. Watch out for dividing by 0 if there is only 1 projectile.
        Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, 20, knockBack, player.whoAmI); //Creates a new projectile with our new vector for spread.
      }
      return false; //makes sure it doesn't shoot the projectile again after this
    }

	}
}
