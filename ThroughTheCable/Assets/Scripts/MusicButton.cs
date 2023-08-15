using UnityEngine;
using UnityEngine.UI;

namespace TTC
{
    public class MusicButton : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private Sprite _spriteOn;
        [SerializeField] private Sprite _spriteOff;

        private bool isOn = true;

        public void ButtonToggle()
        {
            isOn = !isOn;
            if (isOn )
                OnButtonOn();
            else
                OnButtonOff();
        }

        public void OnButtonOn()
        {
            _audioSource.Play();
            _image.sprite = _spriteOn;
        }

        public void OnButtonOff() 
        {
            _audioSource.Stop();
            _image.sprite = _spriteOff;
        }
    }

}

