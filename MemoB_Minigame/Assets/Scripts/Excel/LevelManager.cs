using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class LevelManager : ScriptableObject
    {
        [SerializeField] public LevelInfo levelInfo;
    }



[System.Serializable]
public class LevelInfo
{
    [System.Serializable]
    public struct Layout
    {
        public int Height;
        public int Width;
        public string SpriteLandTexture;
        public int SpriteAirTexture;
        public int SpriteChaosTexture;
        //public Vector2 OriginLocation;
        public Land[] Land;
        public Air[] Air;
        public Chaos[] Chaos;
        public int ExpandTime;
    }
    [System.Serializable]
    public struct Chaos
    {
        public int Code;
       // public Vector2 Location;
        public int Time;
        public string ChaosFallTexture;
    }
    [System.Serializable]
    public struct Air
    {
        //public Vector2 Location;
    }
    [System.Serializable]
    public struct Land
    {
        //public Vector2 Location;
    }

    [System.Serializable]
    public struct Target
    {
        public int Code;
        public WinTargets WinType;
        public int Value;
    }
    public enum WinTargets
    {
        Time=1,
        Coin=2
    }


    public Layout layout;
    public Target[] target;   
}

