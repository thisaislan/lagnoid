
using UnityEngine;

namespace Laganoid.ObjectServices.ObjectModifiers
{
    class Destructor
    {
        public static void Destroy(GameObject gameObject)
        {
            Object.Destroy(gameObject);
        }

    }
}
