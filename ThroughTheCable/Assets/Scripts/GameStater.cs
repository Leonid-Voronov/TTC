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

        private bool _inGameplay;
        public void StartGame()
        {
            screenChanger.ChangeScreenByIndex(1, 4);
            _playerTransform.localPosition = Vector3.zero;
            _speedCalculator.ResetSpeedY();
            _inGameplay = true;
            _gameplayObject.SetActive(true);
        }

        public void FinishGame()
        {
            _inGameplay = false;
            _gameplayObject.SetActive(false);

            //blur background
            _timer.StopTimer();
            screenChanger.ChangeScreenByIndex(4, 6);
        }

        public bool IsInGameplay() { return _inGameplay; }
    }
}

