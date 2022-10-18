using UnityEngine;

namespace MainMenu
{
    public class QuitButton : MonoBehaviour
    {
        public void OnQuitButtonClick()
        {
            Application.Quit();
        }
    }
}