using CityBuilder.Units;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.Overworld
{
    public class OverworldArmy
    {
        Province currentProvince;
        ProvinceNode currentProvinceNode;
        ProvinceNodeData currentNode;
        bool isRaised = false;
        List<Unit> units = new List<Unit>();
    }
}

