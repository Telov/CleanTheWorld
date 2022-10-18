using UnityEngine;
using Zenject;

namespace MainMenu
{
    public class ChangeWindowButton : MonoBehaviour
    {
        [SerializeField] public Window window;
        private IWindowChanger _windowChanger;
        
        [Inject]
        public void Construct(IWindowChanger windowChanger)
        {
            _windowChanger = windowChanger;
        }
        
        public void ChangeWindow()
        {
            _windowChanger.ChangeWindowTo(window);
        }
    }
}
