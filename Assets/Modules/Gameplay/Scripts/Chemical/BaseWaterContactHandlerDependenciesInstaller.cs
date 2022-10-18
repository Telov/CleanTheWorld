using UnityEngine;
using Zenject;

namespace Gameplay.Chemical
{
    public class BaseWaterContactHandlerDependenciesInstaller : MonoInstaller
    {
        [SerializeField] private ParticleSystem WaterSplashesParticleSystem;
        public override void InstallBindings()
        {
            Container.Bind<ParticleSystem>().FromInstance(WaterSplashesParticleSystem).WhenInjectedInto<ChemicalWaterContactHandler>();
        }
    }
}