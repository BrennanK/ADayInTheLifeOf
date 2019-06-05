using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveGlow : MonoBehaviour
{
    Color glowColor;

    float r;
    float gB;

    // Update is called once per frame
    void Update()
    {
        r += .25f * Time.deltaTime;
        gB += .5f * Time.deltaTime;
        glowColor = new Color(Mathf.PingPong(r, .25f), Mathf.PingPong(gB, .5f), Mathf.PingPong(gB, .5f), 1);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", glowColor);
    }
}
