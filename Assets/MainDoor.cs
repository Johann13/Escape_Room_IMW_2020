using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoor : DoorAnimator
{
    public GameManager GameManager;

    public override bool CanOpenDoor()
    {
        return isInRange && GameManager.hasDoorKey;
    }


    public override string OpenMsg()
    {
        if (!CanOpenDoor())
        {
            return "Search the Door Key";
        }
        return base.OpenMsg();
    }
}