using System;
using Cysharp.Threading.Tasks;
using Gameplay.Level;
using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

namespace Gameplay.HoldingStructure
{
    public class BaseSpawner : ISpawner
    {
        public BaseSpawner(IInstantiator instantiator)
        {
            _instantiator = instantiator;
        }

        private readonly IInstantiator _instantiator;

        public async void SpawnChemicals(SpawningInfo spawningInfo)
        {
            for (int i = 0; i < spawningInfo.Count; i++)
            {
                _instantiator.InstantiatePrefab(
                    spawningInfo.GetRandomGO(),
                    spawningInfo.SpawnPoint.position + Random.Range(-1f, 1f) * Vector3.right,
                    Quaternion.identity,
                    spawningInfo.SpawnPoint);

                await UniTask.Delay(TimeSpan.FromSeconds(1 / spawningInfo.SpawnsPerSecond));
            }
        }
    }
}