using ExitGames.Client.Photon;
using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AntiModdedTroll
{
    public class HarmonyPatches : MonoBehaviour
    {

        //fixes issue (come on gt fix the game please)
        [HarmonyPatch(typeof(RoomInfo), "InternalCacheProperties")]
        public class nocrashy
        {
            public static bool Prefix(RoomInfo __instance, Hashtable propertiesToCache)
            {
                if (__instance.masterClientId == PhotonNetwork.LocalPlayer.ActorNumber && propertiesToCache.Count == 1 && propertiesToCache.ContainsKey(248))
                {
                    Debug.Log("trying to crash me");
                    return false;
                }
                return true;
            }

        }


    }

}

