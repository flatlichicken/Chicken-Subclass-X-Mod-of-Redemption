using Terraria;
using Terraria.ModLoader;
using ChickensubclassXRedemption.Content.Items;
using Chickensubclass.Content;

namespace ChickensubclassXRedemption.Content
{
	// The AutoloadEquip attribute automatically attaches an equip texture to this item.
	// Providing the EquipType.Body value here will result in TML expecting a X_Body.png file to be placed next to the item's main texture.
	
	public class MoRChickenWeaponDamageBoost
{
    public static bool IfUsingChickenWeapon(Player player) 
    {
        // list of weapons that get boosted
        int heldItemType = player.inventory[player.selectedItem].type;

        return heldItemType == ModContent.ItemType<FlyingChicken>() ||

               ChickenWeaponDamageBoost.IfUsingChickenWeapon(player);
    }
}

}
