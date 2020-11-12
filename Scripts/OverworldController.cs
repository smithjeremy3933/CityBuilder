using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.Overworld
{
    public class OverworldController : MonoBehaviour
    {
        GameObject hoveredObject;
        OverworldSelection overworldSelection;
        float maxRayDist = 1000f;

        private void Awake()
        {
            overworldSelection = GetComponent<OverworldSelection>();
        }

        private void Update()
        {
            CheckCursor();
        }

        private void CheckCursor()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            bool hasHit = Physics.Raycast(ray, out hitInfo, maxRayDist);

            if (hasHit)
            {
                GameObject hitObject = hitInfo.transform.GetComponentInChildren<Province>().gameObject;

                HoveredObject(hitObject);
            }
            else
            {
                ClearSelection();
            }
        }

        void HoveredObject(GameObject obj)
        {
            if (hoveredObject != null)
            {
                if (obj == hoveredObject)
                    return;

                ClearSelection();
            }

            hoveredObject = obj;
            Debug.Log(hoveredObject.name + " is hovered.");
        }

        void ClearSelection()
        {
            if (hoveredObject == null)
                return;

            hoveredObject = null;
        }
    }
}