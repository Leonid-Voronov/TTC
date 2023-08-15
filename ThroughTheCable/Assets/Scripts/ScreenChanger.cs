using System.Collections.Generic;
using UnityEngine;

namespace TTC
{
    public class ScreenChanger : MonoBehaviour
    {
        [SerializeField] private BackroundChanger backroundChanger;
        [SerializeField] private List<GameObject> screenObjects = new List<GameObject>();

        public void ChangeScreenByIndex(int indexOff, int indexOn)
        {
            if (indexOff < 1 || indexOn < 1 || indexOff > screenObjects.Count || indexOn > screenObjects.Count) return;

            screenObjects[indexOff - 1].SetActive(false);
            screenObjects[indexOn - 1].SetActive(true);
            backroundChanger.ChangeBackground(indexOn);
        }
    }
}

