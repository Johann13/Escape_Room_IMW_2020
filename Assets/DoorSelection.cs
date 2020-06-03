using System;
using System.Collections.Generic;
using UnityEngine;

public class DoorSelection : MonoBehaviour
{
    public string selectableTag = "Door";
    public float distance = 3;
    private Transform selected;

    private Dictionary<string, bool> doors = new Dictionary<string, bool>();

    public Camera cam;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position,
            cam.transform.forward, out hit, distance))
        {
            if (hit.transform.CompareTag(selectableTag))
            {
                selected = hit.transform;
                if (!doors.ContainsKey(selected.name))
                {
                    doors[selected.name] = false;
                }
            }
            else
            {
                selected = null;
            }

            if (selected != null)
            {
                Debug.Log(selected.tag);
            }
        }
        else
        {
            selected = null;
        }


        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log(doors);
            if (selected != null)
            {
                Debug.Log("Open Door: " + selected.tag + ", " + selected.name);
                if (selected.CompareTag(selectableTag))
                {
                    Animator animator = selected.GetComponent<Animator>();
                    if (animator != null)
                    {
                        /*
                        if (doors[selected.name])
                        {
                            Debug.Log(selected.name + " Close");
                            animator.SetTrigger("Close");
                            doors[selected.name] = false;
                        }
                        else
                        {
                            Debug.Log(selected.name + " Open");
                            animator.SetTrigger("Open");
                            doors[selected.name] = true;
                        } */
                        bool closed =
                            animator.GetBool("Closed");
                        animator.SetBool("Closed", !closed);
                        Debug.Log("Closed: " + selected.name + ", " + closed);
                    }
                }

                selected = null;
            }
        }
    }
}