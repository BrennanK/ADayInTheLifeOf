using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Created by: Trahern Moews
 * Date: june/05/2019
 * Purpose: Used to make an interactable object glow so it can stand out from normal objects
 * Uses an objects emission to create the glow effect so as to not mess up the normal material
 */

public class InteractiveGlow : MonoBehaviour
{
    
    //color used for the glow of the object
    Color glowColor;
    

    //bool for shtting off the glow once inspected
    bool inspected;
    bool stopGlow;
    

    // Update is called once per frame
    void Update()
    {
        //bool is flipped in the ShutOffGlow() is this script.
        if (!inspected)
        {
            GetComponent<Renderer>().material.SetColor("_EmissionColor", glowColor);
        }
        else
        {
            //Used to make a soft fade from the emission. 
            //Once R channel emission reaches sub .02 it will destory itself
            if (glowColor.r > .02f)
            {
                GetComponent<Renderer>().material.SetColor("_EmissionColor", glowColor);
            }
            else
            {
                stopGlow = true;
            }
        }
    }

    public void SetGlowColor(Color _temp)
    {
        if (!stopGlow)
        {
            glowColor = _temp;
        }
    }

    public void ShutOffGlow()
    {
        //Called in the Interact script when an interactable object is found.
        inspected = true;
    }
}
