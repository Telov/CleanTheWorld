using UnityEngine;
using Zenject;

namespace MainMenu
{
    public class DefaultWindowChanger : IWindowChanger
    {
        private GameObject _createdGO;
        private readonly IInstantiator _instantiator;
        private WindowsManager _windowsManager;
        private readonly MainMenu _mainMenu;

        public DefaultWindowChanger(IInstantiator instantiator,
            WindowsManager windowsManager,
            MainMenu mainMenu)
        {
            _instantiator = instantiator;
            _windowsManager = windowsManager;
            _mainMenu = mainMenu;
        }

        public void ChangeWindowTo(Window window)
        {
            //start preconditions
            if (window == null) Debug.LogError("Got command to change window to NULL!");
            
            if (window == _windowsManager.GetCurrentWindow()) return;
            //end preconditions

            if (_createdGO != null) GameObject.Destroy(_createdGO);

            _createdGO = _instantiator.InstantiatePrefab(window, _mainMenu.transform);

            _windowsManager.SetCurrentWindow(window);
        }
    }
}