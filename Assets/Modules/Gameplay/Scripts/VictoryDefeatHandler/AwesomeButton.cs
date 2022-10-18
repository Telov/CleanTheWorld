using UnityEngine;
using Zenject;

namespace Gameplay.VictoryDefeatHandler
{
    public class AwesomeButton : MonoBehaviour, IAwesomeButton
    {
        [Inject]
        private void Construct(AudioSource audioSource)
        {
            _audioSource = audioSource;
        }
        private AudioSource _audioSource;
        
        public void PlayAwesomeSound()
        {
            _audioSource.Play();
        }
    }
}