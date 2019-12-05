namespace FUI
open Harmony

[<HarmonyPatch(typeof<GeneratedBuildings>,"LoadGeneratedBuildings")>]
type FUI_GeneratedBuildings_LoadGeneratedBuildings () =
    static member Postfix() =
        Debug.Log("Hello World! FUI")

