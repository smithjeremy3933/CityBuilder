using CityBuilder.Units;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.Overworld
{
    public class OverworldArmy
    {
        Province _province;
        ProvinceData _provinceData;
        ProvinceNode _provinceNode;
        ProvinceNodeData _provinceNodeData;
        public bool isRaised = false;
        public List<Unit> units = new List<Unit>();
        Vector3 _position;
        UnitAlignment _unitAlignment;
        string name;

        public Vector3 Position { get => _position; set => _position = value; }
        public string Name { get => name; }

        public OverworldArmy(ProvinceData provinceData, UnitAlignment unitAlignment) 
        {
            this._provinceData = provinceData;
            this._provinceNodeData = provinceData.ProvinceNodeData;
            this._position = _provinceNodeData.Position;
            this._unitAlignment = unitAlignment;
            this.name = "Army from " + provinceData.Name;
        }
    }
}

