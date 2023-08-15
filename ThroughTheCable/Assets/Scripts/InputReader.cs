using UnityEngine;
using UnityEngine.EventSystems;

namespace TTC
{
    public class InputReader : MonoBehaviour
    {
        [SerializeField] private SpeedCalculator _speedCalculator;
        private void Update()
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began && !EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                {
                    _speedCalculator.OnJump();
                }
            }
        }
    }
}

