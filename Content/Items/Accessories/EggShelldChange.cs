using System.Collections.Generic;
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
            if (item.type == ModContent.ItemType<Redemption.Items.Accessories.PreHM.EggShield>())
            {
                if (MoRChickenWeaponDamageBoost.IfUsingChickenWeapon(player))
                {
                    player.noKnockback = true;
                }
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ModContent.ItemType<Redemption.Items.Accessories.PreHM.EggShield>())
            {
                TooltipLine line = tooltips.Find(l => l.Name == "Tooltip0");
                if (line != null)
                {
                    line.Text = "When below 25% health or using a chicken weapon, you will completely ignore knockback";
                }
            }
        }
    }
}