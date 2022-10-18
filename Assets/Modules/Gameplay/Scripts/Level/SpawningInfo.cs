using System;
using System.Linq;
using Gameplay.ProgressNotifier;
using UnityEngine;

namespace Gameplay.Level
{
    [Serializable]
    public struct SpawningInfo : IMaxProgressProvider

    {
        [SerializeField] public Transform SpawnPoint;
        [SerializeField] public float Count;
        [SerializeField] public float SpawnsPerSecond;
        [SerializeField] private GOChancePair[] SpawnChancesList;

        public int GetMaxProgress()
        {
            return (int)Count;
        }

        public GameObject GetRandomGO()
        {
            return GetGOByChance(SpawnChancesList.Sum(x => x.chance));
        }

        private GameObject GetGOByChance(float chance)
        {
            foreach (GOChancePair pair in SpawnChancesList)
            {
                chance -= pair.chance;
                if (chance <= 0f) return pair.go;
            }

            return null;
        }
    }
}