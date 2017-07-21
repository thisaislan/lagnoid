using Laganoid.ObjectServices;
using Laganoid.ObjectServices.ObjectModifiers;
using UnityEngine;

namespace Laganoid.GameObjects
{
    public class Ball : MonoBehaviour
    {
        public Vector2 direction;
        Score score;
        Rigidbody2D rigidBody;
        GameObject[] blocksCount;
        Accelerator accelerator;
        int scoreLimit = 1000;

        void Awake()
        {
            score = Score.scoreControl;
            accelerator = new Accelerator();
        }

        void Start()
        {            
            rigidBody = GetComponent<Rigidbody2D>();
            rigidBody.AddForce(accelerator.RandomSinalDirectionX(direction));
        }

        void OnCollisionEnter2D(Collision2D collision)
        {            
            if (collision.gameObject.tag.Equals("Block"))
            {
                score.incrementScore();
                CheckIfLastBlock();
                AdjustVelocity();
            }
        }

        void AdjustVelocity()
        {
            if (score.GetScore() == scoreLimit)
            {
                accelerator.ChangeVelocity(gameObject, 20f);
                scoreLimit = scoreLimit + 1000;
            } 
        }

        void CheckIfLastBlock()
        {   
            blocksCount = GameObject.FindGameObjectsWithTag("Block");

            if (blocksCount.Length == 1)
            {
                SceneLoader.ChangeScene(SceneLoader.GAMEOVER);                
            }
        }
    }

}
