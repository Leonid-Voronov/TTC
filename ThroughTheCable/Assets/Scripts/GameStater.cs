using UnityEngine;

namespace TTC
{
    public class GameStater : MonoBehaviour
    {
        [SerializeField] private ScreenChanger screenChanger;
        [SerializeField] private GameObject _gameplayObject;
        [SerializeField] private Transform _playerTransform;
        [SerializeField] private SpeedCalculator _speedCalculator;
        [SerializeField] private Timer _timer;
        [SerializeField] private Blurrer _blurrer;

        private bool _inGameplay;
        public void StartGame()
        {
            screenChanger.ChangeScreenByIndex(1, 4);
            _playerTransform.localPosition = Vector3.zero;
            _speedCalculator.ResetSpeedY();
            _inGameplay = true;
            _timer.ResetTimer();
            _gameplayObject.SetActive(true);
        }

        public void FinishGame()
        {
            _inGameplay = false;
            _gameplayObject.SetActive(false);
            _timer.StopTimer();
            screenChanger.ChangeScreenByIndex(4, 6);
        }

        public void PauseGame()
        {
            _inGameplay = false;
            _blurrer.BlurAll();
            _timer.StopTimer();
            screenChanger.ChangeScreenByIndex(4, 5);
        }

        public void ResumeGame()
        {
            _inGameplay = true;
            _blurrer.DeblurAll();
            _timer.ResumeTimer();
            screenChanger.ChangeScreenByIndex(5, 4);
        }

        public bool IsInGameplay() { return _inGameplay; }
    }
}

