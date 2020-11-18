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
            Debug.Log(allProvinceNodes.Length);
            foreach (ProvinceNode provinceNode in allProvinceNodes)
            {
                ProvinceNode[] neighborNodes = provinceNode.neighborNodes;
                ProvinceNodeData newProvinceNodeData = new ProvinceNodeData(provinceNode)
                {
                    position = provinceNode.transform.position,
                    provinceNode = provinceNode
                };
                foreach (ProvinceNode neighborNode in neighborNodes)
                {
                    ProvinceNodeData newNeighborNodeData = new ProvinceNodeData(neighborNode)
                    {
                        position = neighborNode.transform.position,
                        provinceNode = neighborNode
                    };
                    newProvinceNodeData.neighbors.Add(newNeighborNodeData);
                }
                adjList[newProvinceNodeData] = newProvinceNodeData.neighbors;
            }         
        }
    }
}

