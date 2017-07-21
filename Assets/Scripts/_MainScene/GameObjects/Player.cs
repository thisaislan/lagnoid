using UnityEngine;

namespace Laganoid.GameObjects
{
    public class Player : MonoBehaviour
    {
        public float velocidade;
        public float horizontalAxis;
        public Rigidbody2D rigidBody;

        void Start()
        {
            rigidBody = GetComponent<Rigidbody2D>();
        }
        
        void Update()
        {
            horizontalAxis = Input.GetAxis("Horizontal");
            rigidBody.velocity = new Vector2(velocidade * horizontalAxis, 0);         
        }
    }
}
