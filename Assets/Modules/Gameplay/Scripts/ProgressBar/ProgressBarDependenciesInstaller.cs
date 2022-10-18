using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Gameplay.ProgressBar
{
    public class ProgressBarDependenciesInstaller : MonoInstaller
    {
        [SerializeField] private Slider Slider;
        [SerializeField] private ParticleSystem ParticleSystem;

        public override void InstallBindings()
        {
            Container.Bind<Slider>().FromInstance(Slider).AsSingle();
            Container.Bind<ISliderController>().To<DefaultSliderController>().FromNew().AsSingle();
            Container.Bind<ParticleSystem>().FromInstance(ParticleSystem);
        }
    }
}