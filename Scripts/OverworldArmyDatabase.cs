using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.Overworld
{
    public class OverworldArmyDatabase : MonoBehaviour
    {
        Dictionary<Province, OverworldArmy> provinceOverworldArmyMap = new Dictionary<Province, OverworldArmy>();
    }
}

