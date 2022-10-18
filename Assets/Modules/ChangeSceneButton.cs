using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu
{
    public class ChangeSceneButton : MonoBehaviour
    {
        [SerializeField] private UnityEngine.Object SceneToLoad;
        
        public void LoadScene()
        {
            SceneManager.LoadScene(SceneToLoad.name);
        }
    }
}
