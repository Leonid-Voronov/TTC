using UnityEngine;
using UnityEngine.UI;

namespace TTC
{
    public class VibrationButton : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private Sprite _spriteOn;
        [SerializeField] private Sprite _spriteOff;

        private bool isOn = true;

        public void ButtonToggle()
        {
            isOn = !isOn;
            if (isOn)
                OnButtonOn();
            else
                OnButtonOff();
        }

        public void OnButtonOn()
        {
            _image.sprite = _spriteOn;
        }

        public void OnButtonOff()
        {
            _image.sprite = _spriteOff;
        }
    }

}
