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
    //Used for shutting off the glow effect making the item look normal
    Color baseColor;
    //color used for the glow of the object
    Color glowColor;
    
    // RGB channels for the glow
    float r;
    float g;
    float b;
    //Amount of glow increase perframe. Whole numbers result in fast blinks
    float rIncrease;
    float gIncrease;
    float bIncrease;

    //bool for shtting off the glow once inspected
    bool inspected;

    private void Start()
    {
        // setting base values
        baseColor = GetComponent<Renderer>().material.GetColor("_EmissionColor");
        rIncrease = .5f;
        gIncrease = .5f;
        bIncrease = .5f;
    }

    // Update is called once per frame
    void Update()
    {
        //bool is flipped in the ShutOffGlow() is this script.
        if (!inspected)
        {
            r += rIncrease * Time.deltaTime;
            g += gIncrease * Time.deltaTime;
            b += bIncrease * Time.deltaTime;
            //Do not know how intense this is for processing but it works for the glow (O.o)
            glowColor = new Color(Mathf.PingPong(r, .5f), Mathf.PingPong(g, .5f), Mathf.PingPong(b, .5f), 1);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", glowColor);
        }
        else
        {
            //Used to make a soft fade from the emission. 
            if (glowColor.r > .02f)
            {
                r += rIncrease * Time.deltaTime;
                g += gIncrease * Time.deltaTime;
                b += bIncrease * Time.deltaTime;

                glowColor = new Color(Mathf.PingPong(r, .5f), Mathf.PingPong(g, .5f), Mathf.PingPong(b, .5f), 1);
                GetComponent<Renderer>().material.SetColor("_EmissionColor", glowColor);
            }
        }
    }

    IEnumerator GlowFadeToZero()
    {
        //waits 2 seconds for the softfade to do its job then deletes the script
        yield return new WaitForSeconds(2f);
        Destroy(this);
    }

    public void ShutOffGlow()
    {
        //Called in the Interact script when an interactable object is found.
        inspected = true;
        StartCoroutine(GlowFadeToZero());
    }
}
