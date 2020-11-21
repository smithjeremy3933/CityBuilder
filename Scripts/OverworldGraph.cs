using CityBuilder.Units;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CityBuilder.Overworld
{
    public class OverworldGraph : MonoBehaviour
    {
        Dictionary<ProvinceNodeData, List<ProvinceNodeData>> adjList = new Dictionary<ProvinceNodeData, List<ProvinceNodeData>>();
        ProvinceNode[] allProvinceNodes;
        ProvinceDatabase provinceDatabase;
        int IDcounter = 0;

        public ProvinceDatabase ProvinceDatabase { get => provinceDatabase; }

        public void InitOWGraph()
        {
            allProvinceNodes = FindObjectsOfType<ProvinceNode>();
            provinceDatabase = new ProvinceDatabase();
            foreach (ProvinceNode provinceNode in allProvinceNodes)
            {
                ProvinceNode[] neighborNodes = provinceNode.neighborNodes;
                ProvinceNodeData newProvinceNodeData = new ProvinceNodeData(provinceNode, provinceNode.province, provinceNode.transform.position);
                foreach (ProvinceNode neighborNode in neighborNodes)
                {
                    ProvinceNodeData newNeighborNodeData = new ProvinceNodeData(neighborNode, neighborNode.province, neighborNode.transform.position);
                    newProvinceNodeData.Neighbors.Add(newNeighborNodeData);
                }
                provinceDatabase.AddProvinceData(new ProvinceData(provinceNode.province, provinceNode, newProvinceNodeData, IDcounter));
                IDcounter++;
                adjList[newProvinceNodeData] = newProvinceNodeData.Neighbors;
            }
            SetInitialPlayerProvince(provinceDatabase);
        }

        private static void SetInitialPlayerProvince(ProvinceDatabase provinceDatabase)
        {
            ProvinceData province0 = provinceDatabase.GetProvinceDataByIdx(0);
            province0.ProvinceControl = ProvinceControl.player;
            OverworldArmy overworldArmy = new OverworldArmy(province0, UnitAlignment.player);
            province0.SetOWArmy(overworldArmy);
            Debug.Log(province0.provinceID);
        }
    }
}

