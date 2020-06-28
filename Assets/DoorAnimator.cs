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
    protected bool isInRange = false;


    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange)
        {
            if (_animator.GetBool("Open"))
            {
                msg.text = CloseMsg();
            }
            else
            {
                msg.text = OpenMsg();
            }
        }

        if (_animator != null && CanOpenDoor())
        {
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
        isInRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isInRange = false;
        msg.text = "";
    }

    public virtual bool CanOpenDoor()
    {
        return isInRange;
    }

    public virtual String OpenMsg()
    {
        return openMsg;
    }

    public virtual String CloseMsg()
    {
        return closeMsg;
    }
}