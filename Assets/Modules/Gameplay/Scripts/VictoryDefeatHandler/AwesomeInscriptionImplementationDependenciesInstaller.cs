using UnityEngine;

namespace Gameplay.VictoryDefeatHandler
{
    public class AwesomeInscriptionImplementationDependenciesInstaller : BaseVictoryDefeatImplementationDependenciesInstaller
    {
        [SerializeField] private GameObject AwesomeGameObject;
        [SerializeField] private Transform AwesomeGameObjectPosition;

        public override void InstallBindings()
        {
            base.InstallBindings();
            Container
                .BindInstance(AwesomeGameObject)
                .WithId(AwesomeInscriptionImplementation.AwesomeGameObjectID);

            Container.BindInstance(AwesomeGameObjectPosition);
        }
    }
}