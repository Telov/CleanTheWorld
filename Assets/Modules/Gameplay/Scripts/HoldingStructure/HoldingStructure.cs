using System.Collections.Generic;
using Gameplay.GameController;
using Gameplay.Level;
using UnityEngine;
using Zenject;

namespace Gameplay.HoldingStructure
{
    public class HoldingStructure : MonoBehaviour
    {
        [Inject]
        public void Construct(List<IDoor> doors, ISpawner spawner, IGameBeginner gameBeginner, SpawningInfo spawningInfo)
        {
            _doors = doors;
            _spawner = spawner;
            _gameBeginner = gameBeginner;
            _spawningInfo = spawningInfo;
        }
        
        private List<IDoor> _doors;
        private ISpawner _spawner;
        private IGameBeginner _gameBeginner;
        private SpawningInfo _spawningInfo;

        private void Start()
        {
            _spawner.SpawnChemicals(_spawningInfo);
        }

        private void OnEnable()
        {
            _gameBeginner.OnGameBegin += OpenDoors;
        }

        private void OnDisable()
        {
            _gameBeginner.OnGameBegin -= OpenDoors;
        }
        private void OpenDoors()
        {
            foreach (var door in _doors)
            {
                door.Open();
            }
        }

    }
}