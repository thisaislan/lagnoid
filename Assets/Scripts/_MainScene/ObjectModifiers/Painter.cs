using UnityEngine;

namespace Laganoid.ObjectServices.ObjectModifiers
{
    class Painter
    {
        public void ChangeOpacity(GameObject gameObject, float opacityPercent)
        {
            SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.color = new Color(1f, 1f, 1f, (opacityPercent/100));
        }

    }
}
