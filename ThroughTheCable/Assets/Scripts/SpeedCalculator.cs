using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TTC
{
    public class SpeedCalculator : MonoBehaviour
    {
        [SerializeField] private float acceleration;
        [SerializeField] private float jumpSpeed;

        private float accelerationRate;
        [SerializeField] private float speedY;

        public float SpeedY => speedY;

        private void Start()
        {
            accelerationRate = 1 / acceleration;
        }

        private void FixedUpdate()
        {
            speedY -= acceleration * Time.deltaTime;
        }

        public void OnJump()
        {
            speedY = jumpSpeed;
        }
    }
}

