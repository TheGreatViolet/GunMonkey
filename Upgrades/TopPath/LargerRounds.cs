using Assets.Scripts.Models.Towers;

using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace GunMonkey.Upgrades.BottomPath
{
  public class LargerRounds : ModUpgrade<GunMonkey>
  {
    public override int Path => TOP;
    public override int Tier => 2;
    public override int Cost => 625;

    public override string DisplayName => "Larger Rounds";
    public override string Description => "Gun Monkey rounds have higher pierce and damage";

    public override string Portrait => base.Portrait; // TODO: Add portrait

    public override void ApplyUpgrade(TowerModel towerModel)
    {
      var weapon = towerModel.GetWeapon().projectile;
      weapon.pierce++;
      weapon.GetDamageModel().damage++;
    }
  }
}