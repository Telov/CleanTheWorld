using UnityEngine;
using Zenject;

namespace Gameplay.VictoryDefeatHandler
{
    public class AwesomeInscriptionImplementation : BaseVictoryDefeatImplementation
    {
        public const string AwesomeGameObjectID = nameof(_awesomeGameObject);

        [Inject]
        private void Construct(
            [Inject(Id = AwesomeGameObjectID)] GameObject awesomeGameObject,
            IInstantiator instantiator,
            Transform awesomeGameObjectPosition)
        {
            _instantiator = instantiator;
            _awesomeGameObject = awesomeGameObject;
            _awesomeGameObjectPosition = awesomeGameObjectPosition;
        }

        private IInstantiator _instantiator;
        private GameObject _awesomeGameObject;
        private Transform _awesomeGameObjectPosition;

        public override void Launch()
        {
            base.Launch();
            _instantiator.InstantiatePrefab(_awesomeGameObject, _awesomeGameObjectPosition)
                .GetComponent<IAwesomeButton>().PlayAwesomeSound();
        }
    }
}