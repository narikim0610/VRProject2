using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableTest : MonoBehaviour
{
    
    //È£¹ö
    public void HoverEnter()
    {
        Debug.Log("HoverEnter");
    }

    public void HoverExit()
    {
        Debug.Log("HoverExit");
    }

    public void HoverFirstEnter()
    {
        Debug.Log("HoverFirstEnter");
    }

    public void HoverLastEnter()
    {
        Debug.Log("HoverLastEnter");
    }


    public void SeletedEnter()
    {
        Debug.Log("SeletedEnter");
    }

    public void SeletedExited()
    {
        Debug.Log("SeletedExited");
    }


    public void Activated()
    {
        Debug.Log("Activated");
    }

    public void Deactivated()
    {
        Debug.Log("Deactivated");
    }

}
