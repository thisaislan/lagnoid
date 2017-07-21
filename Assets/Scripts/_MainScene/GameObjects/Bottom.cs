using Laganoid.ObjectServices;
using Laganoid.ObjectServices.ObjectModifiers;
using UnityEngine;

namespace Laganoid.GameObjects
{
    public class Bottom: MonoBehaviour
    {

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag.Equals("Ball"))
            {
                Destructor.Destroy(collision.gameObject);
                SceneLoader.ChangeScene(SceneLoader.GAMEOVER);
            }
        }

        void OnTriggerEnter2D(Collider2D collider)
        {
            Destructor.Destroy(collider.gameObject);
        }

    }
}
