using UnityEngine;
using Zenject;

namespace Gameplay.VictoryDefeatHandler
{
    public class AwesomeButtonDependenciesInstaller : MonoInstaller
    {
        [SerializeField] private AudioSource AudioSource;

        public override void InstallBindings()
        {
            Container.BindInstance(AudioSource);
        }
    }
}