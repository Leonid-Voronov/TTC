using UnityEngine;

namespace TTC
{
    public class InputReader : MonoBehaviour
    {
        [SerializeField] private SpeedCalculator speedCalculator;
        private void Update()
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    speedCalculator.OnJump();
                }
            }
        }
    }
}

