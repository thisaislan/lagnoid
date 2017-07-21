using Laganoid.ObjectServices.ObjectModifiers;
using UnityEngine;

namespace Laganoid.GameObjects
{
    public class Block : MonoBehaviour
    {
        public Rigidbody2D rigidBody;
        public BoxCollider2D collider;

        void Start()
        {
            rigidBody = GetComponent<Rigidbody2D>();
            collider = GetComponent<BoxCollider2D>();
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            Painter painter = new Painter();
            painter.ChangeOpacity(gameObject, 50f);
            rigidBody.constraints = new RigidbodyConstraints2D();
            collider.isTrigger = true;
        }
    }
}
