using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Ray_UI : MonoBehaviour
{
    GraphicRaycaster raycaster;
    Color32 Color32;

    UI_Manager UI_Manager;

    void Awake()
    {
        raycaster = GetComponent<GraphicRaycaster>();
        UI_Manager = GetComponent<UI_Manager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            PointerEventData pointerData = new PointerEventData(EventSystem.current);
            List<RaycastResult> results = new List<RaycastResult>();

            pointerData.position = Input.mousePosition;
            raycaster.Raycast(pointerData, results);

            foreach (RaycastResult result in results)
            {
                if(result.gameObject.tag != "UI_obj")
                return;
               
                Image Image = result.gameObject.GetComponent<Image>();
                UI_Manager.GetImage(Image);
            }
        }
    }

    
}
