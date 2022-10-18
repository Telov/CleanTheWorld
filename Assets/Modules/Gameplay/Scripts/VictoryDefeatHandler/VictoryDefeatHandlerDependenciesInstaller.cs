using Zenject;

namespace Gameplay.VictoryDefeatHandler
{
    public class VictoryDefeatHandlerDependenciesInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IVictoryDefeatImplementation>().To<AwesomeInscriptionImplementation>().AsSingle();
        }
    }
}