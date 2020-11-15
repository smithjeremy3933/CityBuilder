using System;
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
            //InteractWithMovement();
            //PointSelection();
        }

        private void PointSelection()
        {
            
        }

        private void InteractWithMovement()
        {
            
        }

        private void CheckCursor()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            LayerMask provinceMask = LayerMask.GetMask("Province");
            bool hasHit = Physics.Raycast(ray, out hitInfo, maxRayDist, provinceMask);

            if (hasHit)
            {
                GameObject go = hitInfo.collider.gameObject;
                if (Input.GetMouseButtonDown(0))
                {
                    overworldSelection.SetSelectedObject(go);
                }
                HoveredObject(go);
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