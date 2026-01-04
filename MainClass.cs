using BepInEx;
using GorillaLocomotion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilla.Attributes;
namespace AntiModdedTroll
{
    [BepInDependency("org.legoandmars.gorillatag.utilla")]
    [BepInPlugin("Zern.NoCrash", "AntiModdedTroll", "1.0.0")]
    public class MainClass : BaseUnityPlugin
    {
        public static bool allowed;
        void Awake() { GTPlayer.Instance.AddComponent<HarmonyPatches>(); }

        //moddded stuff
        [ModdedGamemodeJoin]
        private void RoomJoined(string gamemode)
        {

            allowed = true;
        }

        [ModdedGamemodeLeave]
        private void RoomLeft(string gamemode)
        {

            allowed = false;
        }
    }
}
