using UnityEngine;

namespace TTC
{
    public class ScreenChangeRequester : MonoBehaviour
    {
        [SerializeField] private ScreenChanger _screenChanger; 
        [SerializeField] private int _indexOff;
        [SerializeField] private int _indexOn;

        public void RequestChange()
        {
            _screenChanger.ChangeScreenByIndex(_indexOff, _indexOn);
        }
    }
}
