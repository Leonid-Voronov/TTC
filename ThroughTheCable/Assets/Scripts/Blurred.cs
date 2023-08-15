using UnityEngine;

namespace TTC
{
    public class Blurred : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        [SerializeField] private Sprite _blurredSprite;
        [SerializeField] private Sprite _normalSprite;

        public void BlurSprite() { _spriteRenderer.sprite = _blurredSprite; }
        public void DeBlurSprite() { _spriteRenderer.sprite = _normalSprite; }
    }
}

