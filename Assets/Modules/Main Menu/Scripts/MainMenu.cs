using UnityEngine;
using Zenject;

namespace MainMenu
{
    public class MainMenu : MonoBehaviour, IInitializable
    {
        
        [SerializeField] private Window StartWindow;
        private IWindowChanger _windowChanger;

        [Inject]
        public void Construct(IWindowChanger windowChanger)
        {
            _windowChanger = windowChanger;
        }

        public void Initialize()
        {
            _windowChanger.ChangeWindowTo(StartWindow);
        }
    }
}
