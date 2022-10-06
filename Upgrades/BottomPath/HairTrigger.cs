using Assets.Scripts.Models.Towers;

using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace GunMonkey.Upgrades.BottomPath
{
  public class HairTrigger : ModUpgrade<GunMonkey>
  {
    public override int Path => BOTTOM;
    public override int Tier => 2;
    public override int Cost => 525;

    public override string DisplayName => "Hair Trigger";
    public override string Description => "Gun Monkey swaps regular trigger for a hair trigger, further increasing attack speed";

    public override string Portrait => base.Portrait; // TODO: Add portrait

    public override void ApplyUpgrade(TowerModel towerModel)
    {
      towerModel.GetWeapon().rate = towerModel.GetWeapon().rate * 0.75f;
    }
  }
}