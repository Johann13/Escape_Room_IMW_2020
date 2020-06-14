using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollected : MonoBehaviour
{
    public GameManager GameManager;

    public GameObject beanBag;

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Camera.main.transform.position,
            transform.position);
        if (Vector3.Distance(beanBag.transform.position,
            transform.position) > 0.8 && distance <= 2 && !GameManager.hasDoorKey)
        {
            GameManager.msgText.text = "Click to Collect Key";
            if (Input.GetMouseButtonDown(0))
            {
                GameManager.hasDoorKey = true;
                Destroy(gameObject);
            }
        }
    }
}