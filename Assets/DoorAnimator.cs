using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorAnimator : MonoBehaviour
{
    // Start is called before the first frame update

    public Text msg;
    public string openMsg = "Click to Open";
    public string closeMsg = "Click to Close";

    private Animator _animator;
    private bool isInRange = false;


    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_animator != null && isInRange)
        {
            if (_animator.GetBool("Open"))
            {
                msg.text = closeMsg;
            }
            else
            {
                msg.text = openMsg;
            }

            if (Input.GetMouseButtonUp(0))
            {
                Debug.Log(name + " MouseClick");
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