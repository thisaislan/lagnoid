using UnityEngine.SceneManagement;

namespace Laganoid.ObjectServices
{
    public static class SceneLoader
    {
        public static readonly string MENU = "Menu";
        public static readonly string MAIN = "Main";
        public static readonly string GAMEOVER = "GameOver";

        public static void ChangeScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
