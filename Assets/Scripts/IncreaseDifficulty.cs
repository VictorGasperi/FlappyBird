using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IncreaseDifficulty 
{
    public static float SetNewSpawnRate(float previousSpawnRate, float difficultyNumber)
    {
        return previousSpawnRate - (1/ difficultyNumber);
    }
}
