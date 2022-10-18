using UnityEngine;
using Zenject;

namespace Gameplay.ProgressBar
{
    public class ProgressBar : MonoBehaviour
    {
        [Inject]
        public void Construct(ISliderController sliderController)
        {
            _sliderController = sliderController;
        }
        
        private ISliderController _sliderController;

        private void Start()
        {
            _sliderController.Launch();
        }
    }
}