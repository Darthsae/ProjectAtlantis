using PASS.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProjectAtlantis.Items.Weapons
{
	public class NautlisStaff : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Summons a Nautlis to fight for you.");
			ItemID.Sets.GamepadWholeScreenUseRange[item.type] = true;
			ItemID.Sets.LockOnIgnoresCollision[item.type] = true;
		}

		public override void SetDefaults() {
			item.damage = 110;
			item.summon = true;
			item.mana = 10;
			item.width = 48;
			item.height = 48;
			item.useTime = 36;
			item.useAnimation = 36;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = Item.buyPrice(0, 30, 0, 0);
			item.rare = ItemRarityID.Cyan;
			item.UseSound = SoundID.Item44;
			item.shoot = mod.ProjectileType("Nautlis");
			item.buffType = mod.BuffType("Nautlis"); //The buff added to player after used the item
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
			if (!player.HasBuff(mod.BuffType("NautlisAguar"))) {
				item.damage = 110;
			} else {
				item.damage = 220;
			}
			player.AddBuff(item.buffType, 2);
			position = Main.MouseWorld;
			return true;
		}
	}
}
