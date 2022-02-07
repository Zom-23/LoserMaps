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
        //IList<string> activeLevels = (IList<string>)AccessTools.Field(typeof(LevelManager), "activeLevels").GetValue(null);
        //IList<string> inactiveLevels = (IList<string>)AccessTools.Field(typeof(LevelManager), "inactiveLevels").GetValue(null);
        readonly IDictionary<string, Level> allLevels = LevelManager.levels;
        IList<string> activeLevels;
        //IList<string> inactiveLevels;

        void levelSetup(ref IList<string> active, ref IList<string> inactive, ref IList<string> redraw, IDictionary<string, Level> all)
        {
            foreach(KeyValuePair<string, Level> levels in all)
            {
                if(levels.Value.enabled)
                {
                    active.Add(levels.Key);
                }
            }
        }


        string[] maps = new string[3];
        int[] votes = new int[3];

        string voting()
        {
            for(int i = 0; i < 3; i++)
            {
                maps[i] = activeLevels[UnityEngine.Random.Range(0, activeLevels.Count())];
            }
            int max = votes.Max();

            Predicate<int> maxFinder = (int i) => { return i == max; };

            return maps[Array.FindIndex(votes, maxFinder)];
        }
    }
}
