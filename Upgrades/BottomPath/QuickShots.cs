using Assets.Scripts.Models.Towers;

using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace GunMonkey.Upgrades.BottomPath
{
  public class QuickShots : ModUpgrade<GunMonkey>
  {
    public override int Path => BOTTOM;
    public override int Tier => 1;
    public override int Cost => 300;

    public override string DisplayName => "Quick Shots";
    public override string Description => "Gun Monkey shoots slightly faster";

    public override string Portrait => base.Portrait; // TODO: Add portrait

    public override void ApplyUpgrade(TowerModel towerModel)
    {
      towerModel.GetWeapon().rate = towerModel.GetWeapon().rate * 0.80f;
    }
  }
}