// Learn more about F# at https://fsharp.org
// See the 'F# Tutorial' project for more help.

//#load "Library1.fs"
//open FUI

// Define your library scripting code here
open System
open System.Diagnostics
let combine y x = System.IO.Path.Combine(x,y)
let getparent x = System.IO.Path.GetDirectoryName x

// this should return the same as d:%HOMEPATH%\My Documents\Klei\OxygenNotIncluded\mods\Dev\$(ProjectName)
let getModFolder () =
    Environment.GetFolderPath Environment.SpecialFolder.MyDocuments
    |> combine @"Klei\OxygenNotIncluded\mods\Dev\FUI"
    |> Process.Start

let getLogFolder () = // https://stackoverflow.com/questions/4494290/detect-the-location-of-appdata-locallow
    Environment.GetFolderPath Environment.SpecialFolder.LocalApplicationData
    |> getparent
    |> combine @"LocalLow\Klei\Oxygen Not Included"
    |> Process.Start


// D:\Games\Steam\steamapps\common\OxygenNotIncluded


