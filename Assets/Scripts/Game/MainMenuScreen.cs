using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class MainMenuScreen : MonoBehaviour
    {
        [UsedImplicitly] 
        public void StartGame()
        {
            SceneManager.LoadSceneAsync(GlobalConstants.GAME_SCENE);
        }
    }
}