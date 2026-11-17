using MiraAPI.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TownOfSanctuary.Roles.Crewmate;

public class Caller : CrewmateRole,ICustomRole
{
    public Color RoleColor => Color.yellow;

    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public string RoleLongDescription => "你可以随时随地召开紧急会议。";
    public string RoleDescription => RoleLongDescription;

    public CustomRoleConfiguration Configuration => new(this) 
    {
        MaxRoleCount = 15,
        DefaultChance = 100,
        DefaultRoleCount = 1
    };
}
