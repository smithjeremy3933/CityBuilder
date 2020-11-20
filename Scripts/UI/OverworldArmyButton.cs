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
                ToggleState(false);
            } else
            {
                ToggleState(true);
            }
        }

        void ToggleState(bool state)
        {
            isArmyUIOpen = state;
            armyMainScreen.SetActive(state);
            armyMainPanel.SetActive(state);
        }
    }
}
