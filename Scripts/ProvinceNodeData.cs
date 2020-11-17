using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CityBuilder.Overworld
{
    public class ProvinceNodeData : IComparable<ProvinceNodeData>
    {
        public ProvinceNodeData previous = null;
        public List<ProvinceNodeData> neighbors = new List<ProvinceNodeData>();
        public Province province;
        public ProvinceNode provinceNode;
        public float distanceTravled = Mathf.Infinity;
        public float priority;

        public ProvinceNodeData(ProvinceNode provinceNode)
        {
            this.provinceNode = provinceNode;
            //this.neighbors = provinceNode.neighborNodes.ToList();
        }

        public int CompareTo(ProvinceNodeData other)
        {
            if (this.priority < other.priority)
            {
                return -1;
            }
            else if (this.priority > other.priority)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void Reset()
        {
            previous = null;
            distanceTravled = Mathf.Infinity;
        }
    }
}

