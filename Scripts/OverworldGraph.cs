using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.Overworld
{
    public class OverworldGraph : MonoBehaviour
    {
        Dictionary<ProvinceNode, ProvinceNode[]> adjList = new Dictionary<ProvinceNode, ProvinceNode[]>();
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
                adjList[provinceNode] = neighborNodes;
            }
            Debug.Log(adjList.Count);
        }
    }
}

