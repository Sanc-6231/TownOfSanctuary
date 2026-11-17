using Reactor.Networking.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownOfSanctuary.Rpcs;
public static class RpcMethods
{
    [MethodRpc((uint)RpcCalls.RpcStartMeeting)]
    public static void RpcStartMeeting(PlayerControl p)
    {
        if (p == null) return;
        if (!MeetingHud.Instance) return;
        if (AmongUsClient.Instance == null || !AmongUsClient.Instance.AmHost) return;
        MeetingRoomManager.Instance.AssignSelf(p,null);
        HudManager.Instance.OpenMeetingRoom(p);
        p.RpcStartMeeting(null);
    }
}


