using CityBuilder.Overworld;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.UI
{
    public class ArmyMainUI : MonoBehaviour
    {
        ProvinceDatabase provinceDatabase;
        List<ProvinceData> provincesWithPlayerArmy;

        void Start()
        {
            provinceDatabase = FindObjectOfType<ProvinceDatabase>();
            provincesWithPlayerArmy = provinceDatabase.GetProvincesWithPlayerArmy();
            Debug.Log(provincesWithPlayerArmy.Count);
        }

        void Update()
        {

        }
    }
}

