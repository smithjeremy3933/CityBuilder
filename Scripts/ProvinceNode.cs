﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.Overworld
{
    public class ProvinceNode : MonoBehaviour
    {
        [SerializeField] public ProvinceNode[] neighborNodes; 
        public bool isExplored = false;
        public ProvinceNode previous;
    }
}

