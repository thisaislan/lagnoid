using Laganoid.ObjectServices;
using Laganoid.Services;
using UnityEngine;

namespace Laganoid.GameObjects
{
    public class Menu : MonoBehaviour
    {
        UnityEngine.UI.Button startButton;
        UnityEngine.UI.Button quitButton;

        void Start()
        {
            UnityEngine.UI.Button startButton
                = GameObject.FindWithTag("StartButton").GetComponent<UnityEngine.UI.Button>();

            startButton.onClick.AddListener(CallMainScene);

            UnityEngine.UI.Button quitButton
                = GameObject.FindWithTag("QuitButton").GetComponent<UnityEngine.UI.Button>();

            quitButton.onClick.AddListener(CallCloseGame);
        }

        void CallMainScene()
        {
            SceneLoader.ChangeScene(SceneLoader.MAIN);
        }

        void CallCloseGame()
        {
            Closer.CloseGame();
        }
    }
}
