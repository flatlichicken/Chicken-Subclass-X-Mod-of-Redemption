using Terraria;
using Terraria.ModLoader;
using Redemption.Items.Accessories.PreHM;
using Chickensubclass.Content;

namespace ChickensubclassXRedemption.Content
{
	public class RedemptionAccessoryModifier : GlobalItem
	{
		public override void UpdateAccessory(Item item, Player player, bool hideVisual)
		{
			if (item.type == ModContent.ItemType<EggShelld>())
			{
                if (MoRChickenWeaponDamageBoost.IfUsingChickenWeapon(player)) player.knockbackResist = 0f;
			}
		}

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (item.type == ModContent.ItemType<EggShelld>())
			{
				if (tooltips.Count > 1)
				{
					tooltips[1].Text = "When below 25% health or using a chicken weapon, you will completely ignore knockback";
				}
			}
		}
	}
}
