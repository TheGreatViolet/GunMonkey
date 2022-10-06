using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;

using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace GunMonkey.Upgrades.BottomPath
{
  public class HPRounds : ModUpgrade<GunMonkey>
  {
    public override int Path => BOTTOM;
    public override int Tier => 3;
    public override int Cost => 1000;

    public override string DisplayName => "Hollow-Point Rounds";
    public override string Description => "Gun Monkey rounds are swapped for hollow-point rounds, which have higher pierce and extra damage against MOAB-class bloons";

    public override string Portrait => base.Portrait; // TODO: Add portrait

    public override void ApplyUpgrade(TowerModel towerModel)
    {
      var weapon = towerModel.GetWeapon().projectile;
      weapon.pierce += 3;
      weapon.GetDamageModel().damage += 2;

      towerModel.GetAttackModel().weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("aaa1", "Moab", 1, 10, false, false));
      towerModel.GetAttackModel().weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("aaa2", "Ddt", 1, 20, false, false));
      towerModel.GetAttackModel().weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("aaa3", "Bfb", 1, 20, false, false));
      towerModel.GetAttackModel().weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("aaa4", "Zomg", 1, 30, false, false));
      towerModel.GetAttackModel().weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("aaa5", "Bad", 1, 50, false, false));
    }
  }
}