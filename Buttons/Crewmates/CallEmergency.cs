using MiraAPI.GameOptions;
using MiraAPI.Hud;
using MiraAPI.Utilities.Assets;
using Rewired.UI.ControlMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownOfSanctuary.Assets;
using TownOfSanctuary.Configuration.Crewmates;
using TownOfSanctuary.Roles.Crewmate;
using UnityEngine;

namespace TownOfSanctuary.Buttons.Crewmates;

public class CallEmergency : CustomActionButton
{
    public override string Name => "紧急会议";

    public override float Cooldown => OptionGroupSingleton<CallerConfig>.Instance.CoolDown.Value;
    public override int MaxUses => (int)OptionGroupSingleton<CallerConfig>.Instance.MaxUses.Value;
    public override LoadableAsset<Sprite> Sprite => Loader.CallEmergencyButtonSprite;

    public override bool Enabled(RoleBehaviour? role)
    {
        return role is Caller;
    }

    protected override void OnClick()
    {
        Rpcs.Rpc.RpcStartMeeting(PlayerControl.LocalPlayer);
    }
}