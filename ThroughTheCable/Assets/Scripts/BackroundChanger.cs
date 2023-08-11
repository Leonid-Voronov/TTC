using System.Collections.Generic;
using UnityEngine;

namespace TTC
{
    public class BackroundChanger : MonoBehaviour
    {
        [SerializeField] private List<Sprite> _backgroundSprites = new List<Sprite>();
        [SerializeField] private SpriteRenderer _spriteRenderer;

        public void ChangeBackground(int screenNumber)
        {
            if (screenNumber <= 1 || screenNumber > _backgroundSprites.Count - 1) return;
            _spriteRenderer.sprite = _backgroundSprites[screenNumber - 1];
        }
    }
}

