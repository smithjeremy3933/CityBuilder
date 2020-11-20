using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.Overworld
{
    public class OverworldArmyView : MonoBehaviour
    {
        [SerializeField] private GameObject overworldArmyGO;
        OverworldArmy overworldArmy;

        public void Init(OverworldArmy overworldArmy)
        {
            if (overworldArmyGO != null)
            {
                gameObject.name = "Army from Province 0";
                gameObject.transform.position = overworldArmy.Position;
            }
        }
    }
}

