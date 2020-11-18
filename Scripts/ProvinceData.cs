using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.Overworld
{
    public class ProvinceData
    {
        public Province province;
        public ProvinceNode provinceNode;
        public ProvinceNodeData provinceNodeData;

        public ProvinceData(Province province, ProvinceNode provinceNode, ProvinceNodeData provinceNodeData)
        {
            this.province = province;
            this.provinceNode = provinceNode;
            this.provinceNodeData = provinceNodeData;
        }
    }
}

