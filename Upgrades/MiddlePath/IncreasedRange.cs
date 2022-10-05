using Assets.Scripts.Models.Towers;

using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace GunMonkey.Upgrades.MiddlePath
{
  public class IncreasedRange : ModUpgrade<GunMonkey>
  {
    public override int Path => MIDDLE;
    public override int Tier => 1;
    public override int Cost => 250;

    public override string DisplayName => "Increased Range";
    public override string Description => "Gun Monkey has increased range";

    public override string Portrait => base.Portrait; // TODO: Add portrait

    public override void ApplyUpgrade(TowerModel towerModel)
    {
      var range = towerModel.range * 1.25f;

      towerModel.range = range;
      towerModel.GetAttackModel().range = range;
    }
  }
}