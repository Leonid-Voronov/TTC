using UnityEngine;

namespace TTC
{
    public class InputReader : MonoBehaviour
    {
        [SerializeField] private SpeedCalculator _speedCalculator;
        private void Update()
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    _speedCalculator.OnJump();
                }
            }
        }
    }
}

