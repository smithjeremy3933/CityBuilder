using CityBuilder.Overworld;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.Units
{
    public enum UnitAlignment
    {
        player = 0,
        enemy = 1
    }

    public class Unit
    {
        public string name;
        public UnitAlignment unitAlignment;
        public float unitID;
        public Province currentProvince;
        public ProvinceNode currentProvinceNodep;

        public float health = 100;
        public float maxActionPoints = 7f;
        public float actionPoints = 7f;
    }
}
