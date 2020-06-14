﻿using System;
using UnityEngine;
using UnityEngine.UI;

public class Selector : MonoBehaviour
{
    public string selectableTag = "Selectable";
    public Material highlightMaterial;
    public float distance = 5;
    public Camera cam;

    private Transform selected;
    private Material prevMaterial;

    void Update()
    {

        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position,
            cam.transform.forward, out hit, distance))
        {
            ResetPreviousSelection();
            if (hit.transform.tag == selectableTag)
            {
                Debug.Log("Selectable: " + hit.transform.name + ", " + hit.transform.tag);
                selected = hit.transform;
                var currentRenderer = hit.transform.GetComponent<Renderer>();
                prevMaterial = currentRenderer.material;
                currentRenderer.material = highlightMaterial;
            }
        }
        else
        {
            ResetPreviousSelection();
        }
    }

    private void ResetPreviousSelection()
    {
        if (selected != null && prevMaterial != null)
        {
            selected.GetComponent<Renderer>().material = prevMaterial;
            selected = null;
            prevMaterial = null;
        }
    }


}