using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.Overworld
{
    public class OverworldArmy : MonoBehaviour
    {
        Province currentProvince;
        ProvinceNode currentProvinceNode;
        bool isRaised = false;
        List<Unit> units = new List<Unit>();
    }
}

