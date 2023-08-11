using UnityEngine;

namespace TTC
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private TMPro.TextMeshProUGUI _textMeshPro;
        private float _timer;
        private bool _stopped;

        private string _currentTimeRepresent = "00:00";
        public string CurrentTimeRepresent => _currentTimeRepresent;

        private void OnEnable()
        {
            _timer = 0;
            _stopped = false;
        }

        private void Update()
        {
            if (!_stopped)
                _timer += Time.deltaTime;

            int timePassedInSeconds = Mathf.FloorToInt (_timer);
            int timePassedInMinutes = Mathf.FloorToInt (timePassedInSeconds / 60);

            timePassedInSeconds = timePassedInSeconds - timePassedInMinutes * 60;

            string minutesText = timePassedInMinutes.ToString();
            string secondsText = timePassedInSeconds.ToString();

            minutesText = AddZero(minutesText);
            secondsText = AddZero(secondsText);


            _currentTimeRepresent = minutesText + ':' + secondsText;
            _textMeshPro.text = _currentTimeRepresent;
        }

        private string AddZero (string text)
        {
            if (text.Length < 2)
                return '0' + text;
            else
                return text;
        }

        public void StopTimer() { _stopped = true; }
        public void ResumeTimer() { _stopped = false; }
    }
}

