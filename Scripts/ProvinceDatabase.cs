using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.Overworld
{
    public class ProvinceDatabase
    {
        List<ProvinceData> provinceDataList = new List<ProvinceData>();

        public ProvinceDatabase()
        {

        }

        public void AddProvinceData(ProvinceData provinceData)
        {
            if (!provinceDataList.Contains(provinceData))
            {
                provinceDataList.Add(provinceData);
            }
        }

        public ProvinceData GetProvinceDataByIdx(int index)
        {
            return provinceDataList[index];
        }
    }
}

