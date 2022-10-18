using UnityEngine;
using Zenject;

namespace Gameplay.ProgressNotifier
{
    public class ProgressNotifierDependenciesInstaller : MonoInstaller
    {
        [SerializeField]
        private BaseProgressNotifier BaseProgressNotifier;

        public override void InstallBindings()
        {
            
            Container
                .Bind(
                    typeof(IProgressListener),
                    typeof(IProgressNotifier))
                .FromInstance(BaseProgressNotifier);
            
            Container.Bind<IEndConditionMetNotifier>().To<BaseEndConditionMetNotifier>().FromNew().AsSingle();
        }
    }
}