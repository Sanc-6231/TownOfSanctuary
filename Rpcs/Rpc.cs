using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownOfSanctuary.Rpcs;

public static class Rpc
{
    public static void RpcStartMeeting(PlayerControl p) => RpcMethods.RpcStartMeeting(p);
}
