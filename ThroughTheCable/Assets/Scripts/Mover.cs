using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TTC
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private SpeedCalculator _speedCalculator;
        [SerializeField] private GameStater _gameStater;

        private void FixedUpdate()
        {
            if (_gameStater.IsInGameplay())
                transform.localPosition += new Vector3 (0f, _speedCalculator.SpeedY * Time.deltaTime ,0f);
        }
    }
}

