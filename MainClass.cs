using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using GorillaLocomotion;
namespace AntiModdedTroll
{
    [BepInPlugin("Zern.NoCrash", "AntiModdedTroll", "1.0.0")]
    public class MainClass : BaseUnityPlugin
    {
        void Awake() { GTPlayer.Instance.AddComponent<HarmonyPatches>(); }    
    }
}
