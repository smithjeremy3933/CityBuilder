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

        private void Start()
        {
            InitOWGraph();
        }

        private void InitOWGraph()
        {
            allProvinceNodes = FindObjectsOfType<ProvinceNode>();
            ProvinceDatabase provinceDatabase = new ProvinceDatabase();
            foreach (ProvinceNode provinceNode in allProvinceNodes)
            {
                ProvinceNode[] neighborNodes = provinceNode.neighborNodes;
                ProvinceNodeData newProvinceNodeData = new ProvinceNodeData(provinceNode, provinceNode.province, provinceNode.transform.position);
                foreach (ProvinceNode neighborNode in neighborNodes)
                {
                    ProvinceNodeData newNeighborNodeData = new ProvinceNodeData(neighborNode, neighborNode.province, neighborNode.transform.position);
                    newProvinceNodeData.Neighbors.Add(newNeighborNodeData);
                }
                provinceDatabase.AddProvinceData(new ProvinceData(provinceNode.province, provinceNode, newProvinceNodeData));
                adjList[newProvinceNodeData] = newProvinceNodeData.Neighbors;
            }         
        }
    }
}

