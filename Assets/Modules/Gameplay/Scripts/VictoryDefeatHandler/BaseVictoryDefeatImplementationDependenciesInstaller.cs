using UnityEngine;
using Zenject;

namespace Gameplay.VictoryDefeatHandler
{
    public class BaseVictoryDefeatImplementationDependenciesInstaller : MonoInstaller
    {
        [SerializeField] protected GameObject BackgroundGO;

        public override void InstallBindings()
        {
            Container
                .BindInstance(BackgroundGO)
                .WithId(BaseVictoryDefeatImplementation.BackgroundGoID)
                .WhenInjectedInto<BaseVictoryDefeatImplementation>();
        }
    }
}