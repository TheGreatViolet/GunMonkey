using Assets.Scripts.Models.Towers;

using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace GunMonkey.Upgrades.MiddlePath
{
  public class IncreasederRange : ModUpgrade<GunMonkey>
  {
    public override int Path => MIDDLE;
    public override int Tier => 2;
    public override int Cost => 250;

    public override string DisplayName => "Increaseder Range";
    public override string Description => "Gun Monkey's range is increased even farther";

    public override string Portrait => base.Portrait; // TODO: Add portrait

    public override void ApplyUpgrade(TowerModel towerModel)
    {
      var range = towerModel.range * 1.50f;

      towerModel.range = range;
      towerModel.GetAttackModel().range = range;
    }
  }
}