using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.UI
{
    public class OverworldArmyButton : MonoBehaviour
    {
        GameObject armyMainUI;
        bool isArmyUIOpen = false;
        

        // Start is called before the first frame update
        void Start()
        {
            armyMainUI = FindObjectOfType<ArmyMainUI>().gameObject;
        }

        public void ToggleArmyMainUI()
        {
            if (isArmyUIOpen)
            {
                isArmyUIOpen = false;
                armyMainUI.SetActive(false);
            } else
            {
                isArmyUIOpen = true;
                armyMainUI.SetActive(true);
            }
        }
    }
}
