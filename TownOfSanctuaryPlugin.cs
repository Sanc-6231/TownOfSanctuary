using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using MiraAPI;
using MiraAPI.PluginLoading;
using Reactor;
using Reactor.Networking;
using Reactor.Networking.Attributes;

namespace TownOfSanctuary;

[BepInPlugin(ToSPluginInfo.GUID, ToSPluginInfo.NAME, ToSPluginInfo.VERSION)]
[BepInProcess("Among Us.exe")]
[BepInDependency(ReactorPlugin.Id)]
[BepInDependency(MiraApiPlugin.Id)]
[ReactorModFlags(ModFlags.RequireOnAllClients)]
public class TownOfSanctuaryPlugin : BasePlugin, IMiraPlugin
{
    public Harmony Harmony { get; } = new("cn.moonscar.tos.harmony");

    public string OptionsTitleText => "TownOfSanctuary";

    public ConfigFile GetConfigFile() => Config;
    public const string Version = "0.0.1";
    public const string VisualVersion = "0.0.1-alpha.1";
    public override void Load()
    {
        Harmony.PatchAll();
    }
}
