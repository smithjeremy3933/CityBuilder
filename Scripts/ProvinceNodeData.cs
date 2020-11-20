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
        List<ProvinceNodeData> neighbors = new List<ProvinceNodeData>();
        public Province province;
        public ProvinceNode provinceNode;
        Vector3 position;

        public float distanceTravled = Mathf.Infinity;
        public float priority;

        public List<ProvinceNodeData> Neighbors { get => neighbors; set => neighbors = value; }
        public Vector3 Position { get => position; }

        public ProvinceNodeData(ProvinceNode provinceNode, Province province, Vector3 position)
        {
            this.provinceNode = provinceNode;
            this.province = province;
            this.position = position;
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

