using UnityEngine;

namespace TTC
{
    public class ResultRepresenter : MonoBehaviour
    {
        [SerializeField] private Timer _timer;
        [SerializeField] private TMPro.TextMeshProUGUI _textMeshProUGUI;
        private void OnEnable()
        {
            _textMeshProUGUI.text = _timer.CurrentTimeRepresent;
        }
    }
}

