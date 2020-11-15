using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.UI
{
    public class OverworldArmyButton : MonoBehaviour
    {
        [SerializeField] public GameObject armyMainScreen;
        [SerializeField] public GameObject armyMainPanel;

        bool isArmyUIOpen = false;

        public void ToggleArmyMainUI()
        {
            if (isArmyUIOpen)
            {
                isArmyUIOpen = false;
                armyMainScreen.SetActive(false);
                armyMainPanel.SetActive(false);
            } else
            {
                isArmyUIOpen = true;
                armyMainScreen.SetActive(true);
                armyMainPanel.SetActive(true);
            }
        }
    }
}
