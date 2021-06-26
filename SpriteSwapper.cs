

using UnityEngine;
using UnityEngine.UI;

namespace TriviaQuizKit
{

    public class SpriteSwapper : MonoBehaviour
    {
        [SerializeField]
        private Sprite enabledSprite = null;

        [SerializeField]
        private Sprite disabledSprite = null;

        private Image image;

        public void Awake()
        {
            image = GetComponent<Image>();
        }

        public void SwapSprite()
        {
            image.sprite = image.sprite == enabledSprite ? disabledSprite : enabledSprite;
        }

        public void SetEnabled(bool spriteEnabled)
        {
            image.sprite = spriteEnabled ? enabledSprite : disabledSprite;
        }
    }
}
