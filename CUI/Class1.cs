using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;



namespace CUI
{
    [HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
    [HarmonyPatch(nameof(GeneratedBuildings.LoadGeneratedBuildings))]
    internal class CUI_GeneratedBuildings_LoadGeneratedBuildings
    {
        static void Postfix() { Debug.Log("Hello World! FUI"); }
    }
}
