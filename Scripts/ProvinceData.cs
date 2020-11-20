using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.Overworld
{
    public enum ProvinceControl
    {
        unnowned, 
        player,
        enemy,
        neutral
    }
    public class ProvinceData
    {
        Province province;
        ProvinceNode provinceNode;
        ProvinceNodeData provinceNodeData;
        ProvinceControl provinceControl;
        string name;
        Vector3 position;
        public int provinceID;

        OverworldArmy _overworldArmy = null;

        public ProvinceData(Province province, ProvinceNode provinceNode, ProvinceNodeData provinceNodeData, int provinceID)
        {
            this.province = province;
            this.position = province.transform.position;
            this.provinceNode = provinceNode;
            this.provinceNodeData = provinceNodeData;
            this.provinceID = provinceID;
            name = province.transform.gameObject.name;
            ProvinceControl = ProvinceControl.unnowned;
            this.province.Init(this);
        }

        public ProvinceControl ProvinceControl { get => provinceControl; set => provinceControl = value; }
        public string Name { get => name; }
        public ProvinceNodeData ProvinceNodeData { get => provinceNodeData; }

        public void SetOWArmy(OverworldArmy overworldArmy)
        {
            _overworldArmy = overworldArmy;
        }
    }
}

