using UnityEngine;

namespace Laganoid.GameObjects
{
    public class Shadow : MonoBehaviour
    {
        public GameObject guiCopy;

        void Awake()
        {
            Vector3 behindPos = transform.position;
            behindPos = new Vector3(guiCopy.transform.position.x, guiCopy.transform.position.y - 0.005f, guiCopy.transform.position.z - 1);
            transform.position = behindPos;
        }

        void Update()
        {
            GetComponent<GUIText>().text = guiCopy.GetComponent<GUIText>().text;
        }
    }
}