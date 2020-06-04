using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorAnimator : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator _animator;
    private bool isInRange = false;

    public Text msg;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange)
        {
            if (_animator != null)
            {
                if (_animator.GetBool("Open"))
                {
                    msg.text = "Click to Close";
                }
                else
                {
                    msg.text = "Click to Open";
                }
            }
        }
        
        if (Input.GetMouseButtonUp(0) && isInRange)
        {
            Debug.Log(name + " MouseClick");
            if (_animator != null)
            {
                bool open =
                    _animator.GetBool("Open");
                _animator.SetBool("Open", !open);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter: " + name);
        isInRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit: " + name);
        isInRange = false;
        msg.text = "";
    }
}