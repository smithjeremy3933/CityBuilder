using CityBuilder.Overworld;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CityBuilder.UI
{
    public class ArmyPanelUI : MonoBehaviour
    {
        ProvinceDatabase provinceDatabase;
        List<ProvinceData> allPlayerProvinces;
        List<Button> ArmyRaiseBtns = new List<Button>();

        public void UpdateArmyMainUI()
        {
            provinceDatabase = FindObjectOfType<ProvinceDatabase>();
            allPlayerProvinces = provinceDatabase.GetAllPlayerProvinces();
            foreach (ProvinceData playerProvince in allPlayerProvinces)
            {
                Button button;
            }
        }
    }
}

