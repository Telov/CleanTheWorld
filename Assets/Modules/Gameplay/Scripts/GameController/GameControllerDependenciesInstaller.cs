using UnityEngine;
using Zenject;

namespace Gameplay.GameController
{
    public class GameControllerDependenciesInstaller : MonoInstaller
    {
        [SerializeField] private Texture2D CursorTexture;
        [SerializeField] private Transform CutsceneEntPoint;
        [SerializeField] private Camera Camera;
        [SerializeField] private float CutsceneDuration;
        public override void InstallBindings()
        {
            InstallDefaultCutsceneExecuter();
            Container.Bind<Texture2D>().FromInstance(CursorTexture).WhenInjectedInto<GameController>();
            Container.Bind(typeof(IGameBeginner), typeof(IInitializable)).To<GameController>().AsSingle();
        }

        private void InstallDefaultCutsceneExecuter()
        {
            Container.Bind<Transform>().FromInstance(CutsceneEntPoint).WhenInjectedInto<DefaultCutsceneExecuter>();
            Container.Bind<float>().FromInstance(CutsceneDuration).WhenInjectedInto<DefaultCutsceneExecuter>();
            Container.Bind<Camera>().FromInstance(Camera).WhenInjectedInto<DefaultCutsceneExecuter>();
            Container.Bind<ICutsceneExecuter>().To<DefaultCutsceneExecuter>().FromNew().AsSingle();
        }
    }
}
