using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Filters;

using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace GunMonkey.Upgrades.TopPath
{
  public class ThermalSights : ModUpgrade<GunMonkey>
  {
    public override int Path => TOP;
    public override int Tier => 1;
    public override int Cost => 325;

    public override string DisplayName => "Thermal Sights";
    public override string Description => "Allows the Gun Monkey to hit camo bloons";

    public override string Portrait => base.Portrait; // TODO: Add portrait

    public override int Priority => -1;

    public override void ApplyUpgrade(TowerModel towerModel)
    {
      towerModel.GetDescendants<FilterInvisibleModel>().ForEach(filter => filter.isActive = false);
    }
  }
}