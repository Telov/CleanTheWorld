using UnityEngine;
using Zenject;

namespace MainMenu
{
    public class WindowWithBackButton : Window
    {
        [SerializeField] private ChangeWindowButton BackButton;
        private WindowsManager _windowsManager;

        [Inject]
        public void Construct(WindowsManager windowsManager)
        {
            _windowsManager = windowsManager;
        }

        private void Start()
        {
            BackButton.window = _windowsManager.GetPreviousWindow();
        }
    }
}
