using UnityEngine;
using Zenject;

namespace MainMenu
{
    public class MainMenuDependenciesInstaller : MonoInstaller<MainMenuDependenciesInstaller>
    {
        [SerializeField] private MainMenu mainMenu;

        public override void InstallBindings()
        {
            Container.Bind<MainMenu>()
                .FromInstance(mainMenu)
                .AsSingle();
            
            Container.Bind<IInitializable>()
                .FromInstance(mainMenu)
                .AsSingle();
            
            Container.Bind<WindowsManager>()
                .FromNew()
                .AsSingle();
            
            Container.Bind<IWindowChanger>()
                .To<DefaultWindowChanger>()
                .AsSingle();
        }
    }
}