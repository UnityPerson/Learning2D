using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Biome", menuName = "ScriptableObjects/Biome", order = 1)]
public class BiomeData : ScriptableObject
{
    public string DebugName = "BiomeName";
    public string[] minimumNoiseRange;
    public string[] maximumNoiseRange;
    public ScriptableObject[] baseTileData;
}
