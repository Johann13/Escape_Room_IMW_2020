using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjct : MonoBehaviour
{
    private Vector3 offset;
    private float mouseZCoord;

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mouseZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDown()
    {
        Debug.Log("MouseDown");
        mouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        offset = gameObject.transform.position - GetMouseWorldPos();
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + offset;
    }
}
