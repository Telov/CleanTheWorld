using Gameplay.Level;
using Gameplay.ProgressNotifier;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ProgressBar
{
    public class DefaultSliderController : ISliderController
    {
        public DefaultSliderController(Slider slider, IProgressNotifier progressNotifier, SpawningInfo spawningInfo, ParticleSystem particleSystem)
        {
            _slider = slider;
            _progressNotifier = progressNotifier;
            _particleSystem = particleSystem;
            _spawningInfo = spawningInfo;
            _sliderMaxValue = (int)_spawningInfo.Count;
        }

        private IProgressNotifier _progressNotifier;
        private Slider _slider;
        private ParticleSystem _particleSystem;
        private SpawningInfo _spawningInfo;
        private int _currentSliderValue;
        private int _sliderMaxValue;

        public void Launch()
        {
            _progressNotifier.OnSuccessfulProgress += (x, y) => AddToSlider();
        }

        private void AddToSlider()
        {
            _slider.value = (float)(++_currentSliderValue) / (float)_sliderMaxValue;
            _particleSystem.Play();
        }
    }
}