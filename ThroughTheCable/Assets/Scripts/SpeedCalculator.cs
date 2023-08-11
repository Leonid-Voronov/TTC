using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TTC
{
    public class SpeedCalculator : MonoBehaviour
    {
        [SerializeField] private GameStater _gameStater;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _jumpSpeed;
        private float _speedY;

        public float SpeedY => _speedY;

        private void FixedUpdate()
        {
            if (_gameStater.IsInGameplay())
                _speedY -= _acceleration * Time.deltaTime;
        }

        public void ResetSpeedY()
        {
            _speedY = 0f;
        }

        public void OnJump()
        {
            if (_gameStater.IsInGameplay())
                _speedY = _jumpSpeed;
        }
    }
}

