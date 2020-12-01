using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.UI
{
    public class OverworldArmyButton : MonoBehaviour
    {
        [SerializeField] public GameObject armyMainScreen;
        [SerializeField] public GameObject armyMainPanel;
        ArmyPanelUI armyPanelUI;

        bool isArmyUIOpen = false;

        public void ToggleArmyMainUI()
        {
            if (isArmyUIOpen)
            {
                ToggleState(false);
            } else
            {
                ToggleState(true);
                armyPanelUI = FindObjectOfType<ArmyPanelUI>();
                armyPanelUI.UpdateArmyMainUI();
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
