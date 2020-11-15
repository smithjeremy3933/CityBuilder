using UnityEngine;
using UnityEngine.EventSystems;

namespace CityBuilder.Overworld
{
    public class OverworldController : MonoBehaviour
    {
        GameObject hoveredObject;
        OverworldSelection overworldSelection;
        readonly float maxRayDist = 1000f;
        bool isHoveringOverUI = false;

        private void Awake()
        {
            overworldSelection = GetComponent<OverworldSelection>();
        }

        private void Update()
        {
            CheckUIClick();
            CheckCursor();
            //InteractWithMovement();
        }

        private void CheckUIClick()
        {
            if (EventSystem.current.IsPointerOverGameObject())
            {
                isHoveringOverUI = true;
            } else
            {
                isHoveringOverUI = false;
            }

            if (Input.GetMouseButtonDown(0))
            {
                if (EventSystem.current.IsPointerOverGameObject())
                {
                    return;
                }
            }
        }

        private void InteractWithMovement()
        {
            
        }

        private void CheckCursor()
        {
            if (!isHoveringOverUI)
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