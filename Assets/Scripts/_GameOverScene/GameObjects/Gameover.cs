using Laganoid.ObjectServices;
using UnityEngine;

namespace Laganoid.GameObjects
{
    public class Gameover : MonoBehaviour
    {
        TreatScore treatScore;
        Score score;
        UnityEngine.UI.Button restartButton;

        void Start()
        {
            UnityEngine.UI.Button restartButton
                = GameObject.FindWithTag("RestartButton").GetComponent<UnityEngine.UI.Button>();

            restartButton.onClick.AddListener(CallMainScene);
        }

        void Awake()
        {
            treatScore = new TreatScore();
            score = Score.scoreControl;
            GetComponent<GUIText>().text = "Score: " + score.GetScore() + "\n Game Over";           
            treatScore.SaveScore(score);
            treatScore.SendScore(score);
            Destroy(score);
        }

        void CallMainScene()
        {
            SceneLoader.ChangeScene(SceneLoader.MENU);
        }
    }
}
