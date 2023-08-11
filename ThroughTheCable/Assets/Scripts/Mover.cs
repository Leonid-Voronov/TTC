using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TTC
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private SpeedCalculator speedCalculator;

        private void FixedUpdate()
        {
            transform.localPosition += new Vector3 (0f, speedCalculator.SpeedY * Time.deltaTime ,0f) ;
        }
    }
}

