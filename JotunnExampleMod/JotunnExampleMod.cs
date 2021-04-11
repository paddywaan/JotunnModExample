// JotunnExampleMod
// a Valheim mod skeleton using JötunnLib
// 
// File:    JotunnExampleMod.cs
// Project: JotunnExampleMod

using BepInEx;
using BepInEx.Configuration;
using UnityEngine;

namespace JotunnExampleMod
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(JotunnLib.Main.ModGuid)]
    //[NetworkCompatibilty(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Minor)]
    internal class JotunnModStub : BaseUnityPlugin
    {
        public const string PluginGUID = "com.jotunn.JotunnExampleMod";
        public const string PluginName = "JotunnExampleMod";
        public const string PluginVersion = "1.0.0";
        public static new JotunnLib.Logger Logger;
        public static new ConfigFile Config;

        private void Awake()
        {
            Config = base.Config;
            // Do all your init stuff here
        }

#if DEBUG
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F6))
            { // Set a breakpoint here to break on F6 key press
            }
        }
#endif
    }
}