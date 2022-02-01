using System;
using BepInEx;
using BepInEx.Configuration;
using UnboundLib;
using HarmonyLib;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Reflection;
using UnboundLib.Utils.UI;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using UnboundLib.GameModes;
using System.Linq;
using Photon.Pun;
using UnboundLib.Networking;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine.SceneManagement;
using System.IO;
using Jotunn.Utils;
using Sirenix.Serialization;

using UnboundLib.Utils;

namespace Loser_Maps
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin(ModId, ModName, "0.1.0")]
    [BepInProcess("Rounds.exe")]

    public class LoserMaps : BaseUnityPlugin
    {
        private const string ModId = "com.Zom.rounds.plugins.losermaps";
        private const string ModName = "Loser Maps";

        internal static bool lockPickQueue = false;
        internal static List<int> playerIDsToPick = new List<int>() { };


    }

    public class MapSelection
    {
        IList<string> activeLevels = (IList<string>)AccessTools.Field(typeof(LevelManager), "activeLevels").GetValue(null);
        IList<string> inactiveLevels = (IList<string>)AccessTools.Field(typeof(LevelManager), "inactiveLevels").GetValue(null);
        IList<string> levelsToRedraw = LevelManager.levels.Where(levels. );
        IDictionary<string, Level> allLevels = LevelManager.levels;
    }
}
