using MelonLoader;

using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;

using Assets.Scripts.Models.Towers;

using GunMonkey;

[assembly: MelonInfo(typeof(GunMonkey.GunMonkeyMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace GunMonkey;

public class GunMonkeyMod : BloonsTD6Mod
{
  public override void OnApplicationStart()
  {
    ModHelper.Msg<GunMonkeyMod>("GunMonkey loaded!");
  }
}

public class GunMonkey : ModTower
{
  public override string BaseTower => TowerType.SniperMonkey; // Placeholder
  public override string Name => "Gun Monkey";
  public override int Cost => 750;

  public override string DisplayName => "Gun Monkey";
  public override string Description => "A gun weilding monkey";
  public override string TowerSet => TowerSetType.Military;

  public override int TopPathUpgrades => 0;
  public override int MiddlePathUpgrades => 0;
  public override int BottomPathUpgrades => 0;

  // TODO: Add icon and portrait
  // public override string Icon => "GunMonkeyIcon";
  // public override string Portrait => "GunMonkeyPortrait";

  public override void ModifyBaseTowerModel(TowerModel towerModel)
  {
    var range = 50;

    towerModel.range = range;
    var attackModel = towerModel.GetAttackModel();
    attackModel.range = range;

    var weapon = attackModel.weapons[0];
    weapon.rate = 0.85f;

    var projectile = weapon.projectile;
    projectile.pierce = 10;

    var damagaModel = projectile.GetDamageModel();
    damagaModel.damage = 1;
  }
}