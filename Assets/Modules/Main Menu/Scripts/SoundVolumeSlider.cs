using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace MainMenu
{
    public class SoundVolumeSlider : MonoBehaviour
    {
        [SerializeField] private AudioMixer AudioMixer;
        [SerializeField] private Slider Slider;

        private void Awake()
        {
            Slider.onValueChanged.AddListener(OnSliderValueChange);
        }

        public void OnSliderValueChange(float value)
        {
            AudioMixer.SetFloat("Volume", 20 * Mathf.Log10(Mathf.Clamp(value, 0.01f, 1f)));
        }
    }
}