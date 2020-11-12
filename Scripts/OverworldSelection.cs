using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.Overworld
{
    public class OverworldSelection : MonoBehaviour
    {
        Dictionary<Province, GameObject> provinceGameobjectMap = new Dictionary<Province, GameObject>();
        GameObject selectedObject;

        public void SetSelectedObject(GameObject go)
        {
            if (selectedObject != go)
            {
                selectedObject = go;
                Debug.Log("Selected a GameObject");
            }
        }

        public void DeselectObject()
        {
            selectedObject = null;
        }

        public bool Contains(GameObject go)
        {
            return selectedObject = go;
        }
    }

}
