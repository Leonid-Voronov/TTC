using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TTC
{
    public class Blurrer : MonoBehaviour
    {
        [SerializeField] private List<Blurred> _blurreds = new List<Blurred>();

        public void BlurAll()
        {
            foreach (var blurred in _blurreds)
            {
                blurred.BlurSprite();
            }
        }

        public void DeblurAll()
        {
            foreach (var blurred in _blurreds)
            {
                blurred.DeBlurSprite();
            }
        }
    }
}

