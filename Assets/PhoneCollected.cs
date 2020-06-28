using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneCollected : MonoBehaviour
{
    public GameManager GameManager;
    public int additionalTime = 300;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Camera.main.transform.position,
            transform.position);
        
        if (distance <= 2 && !GameManager.pickedUpPhone)
        {
            GameManager.msgText.text = "Click to increase your time limit";
            if (Input.GetMouseButtonDown(0))
            {
                GameManager.pickedUpPhone = true;
                GameManager.AddTime(additionalTime);
                Destroy(gameObject);
                GameManager.msgText.text = "";
            }
        }
    }
}