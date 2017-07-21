using UnityEngine;

namespace Laganoid.GameObjects
{
    public class Score : MonoBehaviour
    {
        public int score = 0;
        private int previousScore = 0;
        public static Score scoreControl;

        void Awake()
        {
            scoreControl = this;
            DontDestroyOnLoad(transform.gameObject);
        }

        void Update()
        {
            setText("Score: " + score);

            if (previousScore != score)
            {
                previousScore = score;
            }
        }

        void setText(string text)
        {
            GetComponent<GUIText>().text = text;
        }

        public void incrementScore()
        {
            score += 100;
        }

        public int GetScore()
        {
            return score;
        }
    }
}
