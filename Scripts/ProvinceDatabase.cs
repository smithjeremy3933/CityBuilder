using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.Overworld
{
    public class ProvinceDatabase : MonoBehaviour
    {
        List<ProvinceData> provinceDataList = new List<ProvinceData>();

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

        public List<ProvinceData> GetProvincesWithPlayerArmy()
        {
            List<ProvinceData> provinces = new List<ProvinceData>();
            foreach (ProvinceData province in provinceDataList)
            {
                if (province.ProvinceControl == ProvinceControl.player && province.OverworldArmy != null)
                {
                    provinces.Add(province);
                }
            }
            return provinces;
        }

        public List<ProvinceData> GetAllPlayerProvinces()
        {
            List<ProvinceData> provinces = new List<ProvinceData>();
            {
                foreach (ProvinceData province in provinceDataList)
                {
                    if (province.ProvinceControl == ProvinceControl.player)
                    {
                        provinces.Add(province);
                    }
                }
            }
            return provinces;
        }
    }
}

