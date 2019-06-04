using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

[System.Serializable]
public class Localisation
{
    public string MainMenu_StartGame;
    public string MainMenu_Garage;
    public string MainMenu_Multiplayer;
    public string MainMenu_Options;

    public string DebugPanel_FPS;

    public static Localisation Locale(string jsonString)
    {
        return JsonUtility.FromJson<Localisation>(jsonString);
    }

    public string WithValue(string localisationString, string value)
    {
        return localisationString.Replace("{0}", value);
    }
}