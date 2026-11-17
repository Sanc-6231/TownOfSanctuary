using MiraAPI.GameOptions;
using MiraAPI.GameOptions.OptionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownOfSanctuary.Roles.Crewmate;

namespace TownOfSanctuary.Configuration.Crewmates;

public class CallerConfig : AbstractOptionGroup<Caller>
{
    public override string GroupName => "召集设定";
    public ModdedNumberOption CoolDown { get; } = new("冷却",15,5,60,2.5f,MiraAPI.Utilities.MiraNumberSuffixes.Seconds);
    public ModdedNumberOption MaxUses { get; } = new("最大使用次数",1,1,5,1,MiraAPI.Utilities.MiraNumberSuffixes.None);
}
