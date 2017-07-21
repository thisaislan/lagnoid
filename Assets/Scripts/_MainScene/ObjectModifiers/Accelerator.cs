using UnityEngine;

namespace Laganoid.ObjectServices.ObjectModifiers
{
    class Accelerator
    {
        public void ChangeVelocity(GameObject gameObject, float velocityPercent)
        {
            Rigidbody2D rigidBody = gameObject.GetComponent<Rigidbody2D>();
            rigidBody.velocity = rigidBody.velocity * (1 +  (velocityPercent / 100));
        }

        public Vector2 RandomSinalDirectionX(Vector2 direction)
        {
            if (Random.Range(1, 11) >= 5)
            {
                return new Vector2(direction.x * -1, direction.y);
            }
            return new Vector2(direction.x, direction.y);
        }

    }
}
