using Gameplay.ProgressNotifier;
using UnityEngine;
using Zenject;

namespace Gameplay.Level
{
    public class LevelDependenciesInstaller : MonoInstaller
    {
        [SerializeField] private SpawningInfo SpawningInfo;

        public override void InstallBindings()
        {
            InstallGameController();
        }

        private void InstallGameController()
        {
            Container.Bind(typeof(SpawningInfo), typeof(IMaxProgressProvider)).FromInstance(SpawningInfo);
            
        }
    }
}