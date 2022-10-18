using System;
using Cysharp.Threading.Tasks;
using Gameplay.ProgressNotifier;
using Gameplay.Water;
using UnityEngine;
using Zenject;

namespace Gameplay.Chemical
{
    public class ChemicalWaterContactHandler : MonoBehaviour, IWaterContactHandler
    {
        [Inject]
        public void Construct(ParticleSystem particleSystem, IInstantiator instantiator, IProgressListener progressListener)
        {
            _waterSplashesParticleSystem = particleSystem;
            _instantiator = instantiator;
            _progressListener = progressListener;
        }

        private ParticleSystem _waterSplashesParticleSystem;
        private IInstantiator _instantiator;
        private IProgressListener _progressListener;

        public async void HandleWaterContact(Vector3 position)
        {
            var createdParticleSystem = _instantiator.InstantiatePrefab(_waterSplashesParticleSystem, position, Quaternion.identity, null)
                .GetComponent<ParticleSystem>();
            createdParticleSystem.Play();
            _progressListener.NotifyOfProgress(false);
            await UniTask.Delay(TimeSpan.FromSeconds(createdParticleSystem.main.duration));
            if (createdParticleSystem != null)
            {
                Destroy(createdParticleSystem.gameObject);
            }
        }
    }
}