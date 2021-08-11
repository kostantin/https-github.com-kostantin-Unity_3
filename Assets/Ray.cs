using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour
{
    
    Camera targetCamera;

    //Vector3 originalScreenTargetPosition;

    //Vector3 originalRigidbodyPos;

    //float selectionDistance;

    public UI_Manager UI_Manager;

    void Start()
    {
        targetCamera = GetComponent<Camera>();
    }

    void Update()
    {
        if (!targetCamera) return;

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            UnityEngine.Ray ray = targetCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                /* Material cubeMaterial = hit.transform.GetComponent<Renderer>().material;
                //cubeMaterial.SetColor("_Color", Color.red);
                Color32 color32 = cubeMaterial.color;
                //Debug.Log( color32); */

                Renderer Renderer = hit.transform.GetComponent<Renderer>();

                UI_Manager.GetRenderer(Renderer);
            }
        }
    }

   /*  void GetColor()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;

        // create new colors array where the colors will be created.
        Color[] colors = new Color[vertices.Length];

        Debug.Log(colors);

        // for (int i = 0; i < vertices.Length; i++)
        //     colors[i] = Color.Lerp(Color.red, Color.green, vertices[i].y);

        // // assign the array of colors to the Mesh.
        // mesh.colors = colors;
    } */
}
